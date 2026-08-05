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
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5FD00", Offset = "0x7E5E300", VA = "0x187E5FD00")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA705D0", Offset = "0xA6EBD0", VA = "0x180A705D0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA70610", Offset = "0xA6EC10", VA = "0x180A70610")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E5FD80", Offset = "0x7E5E380", VA = "0x187E5FD80", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x282D140", Offset = "0x282B740", VA = "0x18282D140")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[HIAEMPMDAHB]
internal class DFAHICPPBFF : NGCEPPMGHAN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct KHABKOKANKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public DFAHICPPBFF <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public IJIIPECBIPC avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly NIOGKELFOOL HBKMJBDIGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly OGDMIODCIAH GOHPBJPMIPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly DHONNKDKFCL PAAAEMKHMFP;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7E446F0", Offset = "0x7E42CF0", VA = "0x187E446F0")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	[UsedImplicitly]
	internal static void LIOLFPLPJOM(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7E452E0", Offset = "0x7E438E0", VA = "0x187E452E0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DFAHICPPBFF([GGNLMCAPMLP(null)] NIOGKELFOOL HBKMJBDIGKK, [GGNLMCAPMLP(null)] OGDMIODCIAH GOHPBJPMIPJ, [GGNLMCAPMLP(null)] DHONNKDKFCL PAAAEMKHMFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7E43E30", Offset = "0x7E42430", VA = "0x187E43E30", Slot = "5")]
	public JMOEBMFNCHJ KOLMPBIHOPG(IJIIPECBIPC ELBKFGNIPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7E44760", Offset = "0x7E42D60", VA = "0x187E44760", Slot = "4")]
	public JMOEBMFNCHJ MGFOKMGNHOP(IJIIPECBIPC ELBKFGNIPML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7E439A0", Offset = "0x7E41FA0", VA = "0x187E439A0", Slot = "6")]
	public EMANPBGJAME CNMICMOLPGP(JMOEBMFNCHJ ACJFHCNBBBO, int EHGJOAMMNGG, string? IEDAJGLJHNI, string? JHAGCIKJBEG, JHEMHCNCGNK CEHECLIMMGG, List<MDMFDAOEDCK>? NGAFGAMLNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7E43830", Offset = "0x7E41E30", VA = "0x187E43830", Slot = "7")]
	public bool AIGOCEBEKGI(NMEEMBGLHAM CKBHKJBKBBB, [Out] JMOEBMFNCHJ? NHMMIOKPODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7E438C0", Offset = "0x7E41EC0", VA = "0x187E438C0", Slot = "8")]
	public bool BEFGKCENICM(EMANPBGJAME BFHIDMHLOBK, [Out] JMOEBMFNCHJ? NHMMIOKPODG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7E45250", Offset = "0x7E43850", VA = "0x187E45250", Slot = "9")]
	public bool NONAEKPABHJ(EMANPBGJAME BFHIDMHLOBK, [Out] JACLIKLBEMH? CKBHKJBKBBB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3996A50", Offset = "0x3995050", VA = "0x183996A50")]
	private bool HKHHCIJDPPA<TInput, TOutput>(TInput FCHACHIDAGA, CLFIHJNCEEK<TInput, TOutput> IIELOAAANOK, [Out] TOutput? HPCDHGHHCOO) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7E43AB0", Offset = "0x7E420B0", VA = "0x187E43AB0")]
	[CompilerGenerated]
	private AJOBEKMPNIB EHOLIHAFLGI(FaceFeatureType DEDCIKNHKNM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7E43C50", Offset = "0x7E42250", VA = "0x187E43C50")]
	[CompilerGenerated]
	private AJOBEKMPNIB HBPAGMAKKFM(FaceFeatureType DEDCIKNHKNM, KHABKOKANKE P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[HIAEMPMDAHB]
internal class ALAFIDPCGBO : NIOGKELFOOL
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void ANKFCNNHDOE<in TData>(TData NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class GLFFMDBKMLH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public NMCJNEPGFJN rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JJPDJGJNDNK currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public JJPDJGJNDNK latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
		public GLFFMDBKMLH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7E5FCE0", Offset = "0x7E5E2E0", VA = "0x187E5FCE0")]
		internal bool PGGGHFEODOL(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7E5FC60", Offset = "0x7E5E260", VA = "0x187E5FC60")]
		internal bool GKFJBKABGEH(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly DHONNKDKFCL PAAAEMKHMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HJILBECDIFL KOFKJMOGEGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly ANKFCNNHDOE<JMOEBMFNCHJ>?[] HBKMJBDIGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly ANKFCNNHDOE<JACLIKLBEMH>?[] BEKKIEBBPCL;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7E40B30", Offset = "0x7E3F130", VA = "0x187E40B30")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	[UsedImplicitly]
	internal static void LIOLFPLPJOM(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7E40D20", Offset = "0x7E3F320", VA = "0x187E40D20")]
	[RecRoom.NoEngine.Common.Preserve]
	internal ALAFIDPCGBO([GGNLMCAPMLP(null)] DHONNKDKFCL PAAAEMKHMFP, [GGNLMCAPMLP(null)] HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F5C0", Offset = "0x7E3DBC0", VA = "0x187E3F5C0", Slot = "4")]
	public bool GCLFINBFKKC(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F460", Offset = "0x7E3DA60", VA = "0x187E3F460", Slot = "5")]
	public bool GCLFINBFKKC(JACLIKLBEMH CKBHKJBKBBB, IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F950", Offset = "0x7E3DF50", VA = "0x187E3F950")]
	private void JEJLJKABGGK(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F6F0", Offset = "0x7E3DCF0", VA = "0x187E3F6F0")]
	private void HLPALPCINNF(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F920", Offset = "0x7E3DF20", VA = "0x187E3F920")]
	private void IBOCNMAICLI(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F6C0", Offset = "0x7E3DCC0", VA = "0x187E3F6C0")]
	private void GLAHAEHGCCA(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7E40BA0", Offset = "0x7E3F1A0", VA = "0x187E40BA0")]
	private void NKOMAOAEGNM(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F1E0", Offset = "0x7E3D7E0", VA = "0x187E3F1E0")]
	private void CEIPKJJAICD(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7E40C70", Offset = "0x7E3F270", VA = "0x187E40C70")]
	private void OHJHOOJPLMC(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F1D0", Offset = "0x7E3D7D0", VA = "0x187E3F1D0")]
	private void BMMPBIMKKBH(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F1A0", Offset = "0x7E3D7A0", VA = "0x187E3F1A0")]
	private void AEAHFECJFFL(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? HKKDKDDKEBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7E40850", Offset = "0x7E3EE50", VA = "0x187E40850")]
	private void KIPOADDNMNE(JMOEBMFNCHJ NHMMIOKPODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7E40570", Offset = "0x7E3EB70", VA = "0x187E40570")]
	private JMOEBMFNCHJ KGKIKMMPNEF(JMOEBMFNCHJ NHMMIOKPODG, List<RangeMigration> AFNAJDHILCF, JJPDJGJNDNK HELGNLDECMC, JJPDJGJNDNK GFDECLGBEIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7E40530", Offset = "0x7E3EB30", VA = "0x187E40530")]
	private float JFFFAIMKNLN(float KLHOMAAINAO, Vector2 GMNAFEHDOGH, Vector2 KIHIMGECMDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7E3F290", Offset = "0x7E3D890", VA = "0x187E3F290")]
	private (RangeMigration?, RangeMigration?) DHKFCJBBDKI(List<RangeMigration> NELBJKICLCN, NMCJNEPGFJN PGPHBDDEBJD, JJPDJGJNDNK HELGNLDECMC, JJPDJGJNDNK GFDECLGBEIP)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface NIOGKELFOOL
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool GCLFINBFKKC(JMOEBMFNCHJ NHMMIOKPODG, IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool GCLFINBFKKC(JACLIKLBEMH CKBHKJBKBBB, IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC);
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
		public IOFGNMCHEGE AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7E41380", Offset = "0x7E3F980", VA = "0x187E41380")]
		public void HLNMAJIKEJJ(AnimationPoseSetting HOPHFOOKMCC, float IEILOGHOKPA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7E414B0", Offset = "0x7E3FAB0", VA = "0x187E414B0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x7E41DC0", Offset = "0x7E403C0", VA = "0x187E41DC0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7E41D80", Offset = "0x7E40380", VA = "0x187E41D80")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7E414D0", Offset = "0x7E3FAD0", VA = "0x187E414D0")]
		private void DCGAINKMNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE150", Offset = "0x7DCC750", VA = "0x187DCE150", Slot = "4")]
		public void SetEnabled(bool IOAJJAMFEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7E41DF0", Offset = "0x7E403F0", VA = "0x187E41DF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E41E30", Offset = "0x7E40430", VA = "0x187E41E30")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E41E70", Offset = "0x7E40470", VA = "0x187E41E70")]
		public AnimationPoseSetting BCOBILHGOJF(IOFGNMCHEGE PHLOFIOJEMP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7E41EA0", Offset = "0x7E404A0", VA = "0x187E41EA0")]
		public void PNLBMDNIIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7E41EE0", Offset = "0x7E404E0", VA = "0x187E41EE0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum CBIBANHNBKH
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[DOIDGFGIDBO(CNNBEEFOMHL.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private CBIBANHNBKH handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x7E429F0", Offset = "0x7E40FF0", VA = "0x187E429F0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7E429B0", Offset = "0x7E40FB0", VA = "0x187E429B0")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7E42390", Offset = "0x7E40990", VA = "0x187E42390")]
		private void DCGAINKMNAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7DCE150", Offset = "0x7DCC750", VA = "0x187DCE150", Slot = "4")]
		public void SetEnabled(bool IOAJJAMFEKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7E42A20", Offset = "0x7E41020", VA = "0x187E42A20")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, BDOEGNKBLLO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private IJIIPECBIPC avatarBodyType;

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
		[DOIDGFGIDBO(CNNBEEFOMHL.SelfAndChildren, false, false, false)]
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
		private LFDHGFIANLC FPBFGGKGPOM;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public LFDHGFIANLC GGHIBHIOFFH
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB6D400", Offset = "0xB6BA00", VA = "0x180B6D400", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform AGENGIMAKOJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7E43810", Offset = "0x7E41E10", VA = "0x187E43810", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7E42A50", Offset = "0x7E41050", VA = "0x187E42A50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7E436D0", Offset = "0x7E41CD0", VA = "0x187E436D0")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7E43680", Offset = "0x7E41C80", VA = "0x187E43680")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7E43610", Offset = "0x7E41C10", VA = "0x187E43610")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7E42A50", Offset = "0x7E41050", VA = "0x187E42A50", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7E42DE0", Offset = "0x7E413E0", VA = "0x187E42DE0", Slot = "6")]
		public LFDHGFIANLC CreateAvatarSystem(string IMCDAOINJPM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7E43610", Offset = "0x7E41C10", VA = "0x187E43610", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7E42B10", Offset = "0x7E41110", VA = "0x187E42B10", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7E43720", Offset = "0x7E41D20", VA = "0x187E43720", Slot = "9")]
		public void UpdatePostIKAnimControllers(float OGJBAEEMPIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class EKGGAKAHBGP : LFDHGFIANLC
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class DBMEJBJDJFM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 COPOGCFIKHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion DCJOIPHNCGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 MJLHIEBEMCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform KJDLIGBADOF;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 DJAGOBGDGCJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x20CCCF0", Offset = "0x20CB2F0", VA = "0x1820CCCF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x20CCD10", Offset = "0x20CB310", VA = "0x1820CCD10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion JIDMENBHBJO
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x14FDDA0", Offset = "0x14FC3A0", VA = "0x1814FDDA0")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x14FDFC0", Offset = "0x14FC5C0", VA = "0x1814FDFC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float ANDFNEFEJID
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x118A870", Offset = "0x1188E70", VA = "0x18118A870")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x1915BD0", Offset = "0x19141D0", VA = "0x181915BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool BMLDLNPNILD
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA50DF0", Offset = "0xA4F3F0", VA = "0x180A50DF0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA50E10", Offset = "0xA4F410", VA = "0x180A50E10")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool ILBDPMNEFGA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA50E60", Offset = "0xA4F460", VA = "0x180A50E60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA50E30", Offset = "0xA4F430", VA = "0x180A50E30")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool OIEDICLDMKF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA50D40", Offset = "0xA4F340", VA = "0x180A50D40")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA50C80", Offset = "0xA4F280", VA = "0x180A50C80")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float APFAGCECEID
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD384E0", Offset = "0xD36AE0", VA = "0x180D384E0")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xD384F0", Offset = "0xD36AF0", VA = "0x180D384F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7E61470", Offset = "0x7E5FA70", VA = "0x187E61470")]
		public void ABOMPOIPHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7E61B10", Offset = "0x7E60110", VA = "0x187E61B10")]
		public void NKELNFGBCMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7E61480", Offset = "0x7E5FA80", VA = "0x187E61480")]
		public float AMPCAKBDLBF(Vector3 BFPJBLOHOLJ, Quaternion CGJKABEJEON, [In] AvatarFootSettings FEFEDOOKKAF, float HHFFPECGGNL)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7E61B40", Offset = "0x7E60140", VA = "0x187E61B40")]
		public void PJDIGCAAGLP(Vector3 HCMPFNEBKNP, Quaternion JJKCLNBKJKI, Transform FJEBKPCGKAE, float HPBLEGMCKCF, bool KEFNDEOENFH, bool MNCIBCNIFGA, float KMBEKNICGLB, float LKBKAIKOJCM, Transform CMAFOEIBEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7E61690", Offset = "0x7E5FC90", VA = "0x187E61690")]
		public void FFBPPOHNBIJ(Transform FBFHOFAAHJF, Transform CMAFOEIBEKN, bool KLAKNICFJCP, bool JBCHOHFJAGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7E61A10", Offset = "0x7E60010", VA = "0x187E61A10")]
		private void KFIPLADAHBC(Transform CMAFOEIBEKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7E618C0", Offset = "0x7E5FEC0", VA = "0x187E618C0")]
		public bool JNAIGHEAJCN(Transform CMAFOEIBEKN, AvatarFullBodyConfiguration HHBGHAKIGCN, Vector3 MHLLFNENDMN, float NFJEGIEPOOL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7E61B20", Offset = "0x7E60120", VA = "0x187E61B20")]
		public void NMJMKKCLKIG(float LKBKAIKOJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7E62220", Offset = "0x7E60820", VA = "0x187E62220")]
		public DBMEJBJDJFM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class LICOEGCHKBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float KBHKENFPIHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool JMCBKJMAJKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting CGBCJDJJLEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float PLMCOCPNKCG;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7E69BF0", Offset = "0x7E681F0", VA = "0x187E69BF0")]
		public void JHLNCHCHKMM(IKSolverVR.Arm IKKLKMPEEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7E69A70", Offset = "0x7E68070", VA = "0x187E69A70")]
		public void HFGJJIEGOJB(IKSolverVR.Arm IKKLKMPEEDN, float CKBNHNBBPOB, bool JMCBKJMAJKF, AvatarFullBodyConfiguration HHBGHAKIGCN, float MMEJKCJEAIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7E69C20", Offset = "0x7E68220", VA = "0x187E69C20")]
		private void JJOIJBKKOJD(IKSolverVR.Arm IKKLKMPEEDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7E69690", Offset = "0x7E67C90", VA = "0x187E69690")]
		public void GFMNNJCINJL(IKSolverVR.Arm IKKLKMPEEDN, Transform DEIFEDHIMCF, Transform FJEBKPCGKAE, Quaternion BKKJPPFKDCJ, Vector3 OOHNEPPNDFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7E69200", Offset = "0x7E67800", VA = "0x187E69200")]
		private (Vector3, Quaternion) DIAMLKJHIJK(ILAJJMPAFDF MJGAGOMHHNJ, Quaternion AHAGFDBDOKI, Vector3 EDKIACDAOAM)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A260", Offset = "0x7E68860", VA = "0x187E6A260")]
		public void NGOMEJEOBNO(ILAJJMPAFDF MJGAGOMHHNJ, IKSolverVR.Arm IKKLKMPEEDN, Quaternion AHAGFDBDOKI, Vector3 EDKIACDAOAM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7E69C60", Offset = "0x7E68260", VA = "0x187E69C60")]
		public void MPKPLIBOJLO(ILAJJMPAFDF MJGAGOMHHNJ, IKSolverVR.Arm IKKLKMPEEDN, Quaternion AHAGFDBDOKI, Vector3 EDKIACDAOAM, [In] AvatarFullBodyConfiguration HHBGHAKIGCN, [In] GBNAHHBJLGF DCPJOMEJHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7E69AB0", Offset = "0x7E680B0", VA = "0x187E69AB0")]
		public void HHGGHFPIACP(IOFGNMCHEGE NLCDGDPCMAJ, AvatarFullBodyConfiguration HHBGHAKIGCN, GBNAHHBJLGF DCPJOMEJHIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A3C0", Offset = "0x7E689C0", VA = "0x187E6A3C0")]
		public void PFPENPMDJKJ(IKSolverVR.Arm IKKLKMPEEDN, Transform DEIFEDHIMCF, Vector3 ADLFNLFAEAH, float JANHKKCIDFP, Quaternion FAHLMLCALBD, Vector3 LLCCLEFNMDL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7E6A860", Offset = "0x7E68E60", VA = "0x187E6A860")]
		public LICOEGCHKBL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum MPHPPPEJPCG
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
	private struct MPOMANCIBJJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct HECNPEMEFID
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int LCBLECIJLMK;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int LHEKOELGLEG;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int ANKCPKHLBOM;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int CMMHHJENIIF;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int DKBDMBPDFNP;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int INKLJGJCGDE;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int AOFODCBOLBF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int KCINHFJELOM;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int NLENNPKPMFG;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JENFLEKIBAF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int DAKEFICIOIK;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int GIGAOLIEJBD;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int FKNNGBJHBGL;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int PMLCOMMJFFC;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int INDGEACGKPH;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int JOFBNCJOJPK;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int ONDEAPHHLEF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int NNJJMJFIDIE;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int BKPBHHJOCGE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int OEACMFBCGOF;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int PIMPJGLPIGC;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int CDPGHANCMDD;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int INJHGPEJBEA;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int JLAJKBCDCEE;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int GLDBKHEJHGL;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int EFDFDANMOOM;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int OCEGOJOBOCO;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int CNKIEEFMMLE;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int FMAHFCJICDI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int GCCEGALDDOK;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int CFBDGHFKDBC;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int AHMAEDFMJME;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 NDMIFBDEPLN;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int HPPNGGPNJIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool EIJHLKLFEEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool PFLNLJLJHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool BLFCGFKANFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool NNCDDDHIIJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool ADHJMNOJAOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool IMDDCCECILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 DKCKDAPFIKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string IGPDOHACKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private BKGEJPIHGBJ? KDLKDOLEPND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private KBJHHPNGGLL? HLPMPIBAGEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private EHBLLFIPHCP NIMKIDOFEHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private ALNCFKMOOBP MIBLFDMHLFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private ILAJJMPAFDF JDMOBBJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private ILAJJMPAFDF PIDNDMDHDKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool GHLIAPLMLDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool OCBPOHLILGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly NCKLCGGNIDD JBFOHOOEHKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly HIPIIHDMKCD HHHPBPCGFEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int EHHPENKNAMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float PDNGHIBNMPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject HDGGDNMFGAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform EDKKBCHABGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform KFCCNBIEFOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform NBLPOFAGLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform EBKLFINFDCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float LNOJHIICBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float LAKEOKPLLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 ICCDCDPOCBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion KEKICNHALAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform OIDJKAFCPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform JHLKPEGHKIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform GICEGCLNONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private DNAAJDGKPED CELCKNGIAFE;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker PIAIFNCMLIJ;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker MIGMOMKFAFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker IOIMCMNEIGH;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker PPFDFMMKBEF;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker HNKPGELNNMO;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker OLLCAGOHLEF;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<EKGGAKAHBGP> AIHCGLFNAOK;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int GKGHCKIMAKP;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> LMIBPHKHLHN;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int BLOHKKNMPPO;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int NFFCPBFLBIE;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int HCBNECNKOIF;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int HHLBGIGFJOE;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float PPHPNBOCJNC;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int EMAPLLHMEPP;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float EPOMKHLMCOC;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float KEHLBBAEHKM;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float CBDFHLDDHHI;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float HCOFGEEJFAO;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static NAGCMCNGOAD KEOKBOJCHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float NNHCBIICBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool AACDKNMPNEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float AKEBHCIFLOK;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int MPGIOMJGIMM;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int ENGKOJANKDG;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int BNJCLCMNEGM;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int PGPKJIILJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private DBMEJBJDJFM HKCOJBBIGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private DBMEJBJDJFM POHIENKJFLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float OGDAHKOIKEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 KGADLGNHJIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 EIEBEKHLOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool OMJPNNDDJKA;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion KBJPNENNODJ;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion JBAHDMMMBMH;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 CMKMMLFMAPP;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 DMBIJBDOBFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float ILIJKBIBHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float NDACEKCHEGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private LICOEGCHKBL NJIDENGHBKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private LICOEGCHKBL NCJLKFDEKFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private CEIPOOHGIGO BGILEPAJPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private FFLJIHHDJAM HACGIGPEMCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly MKNOCCPCICP BJGEGDOKEJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float NKJFBAOBMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float ECKDGHAKIGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly FFLJIHHDJAM CHGBJGCEIJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 ALNJOBGPJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 JONLHHPFMDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float LPBFPCMAAIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float KFPCEGIJFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly FFLJIHHDJAM CKJBAHGFIDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly CEIPOOHGIGO AMNEFKLNONP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly FFLJIHHDJAM IEAPGNLOODK;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public LGEBFGGIOJB LFOBPLEFNAL
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public LGEBFGGIOJB BPHJFCKOHBI
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration FONOMDDMIJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7E54BB0", Offset = "0x7E531B0", VA = "0x187E54BB0", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public IJIIPECBIPC FLBKDBJALPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7E465C0", Offset = "0x7E44BC0", VA = "0x187E465C0", Slot = "24")]
		get
		{
			return default(IJIIPECBIPC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration ODGGKIDGBPD
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7E4BD80", Offset = "0x7E4A380", VA = "0x187E4BD80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform LDJPICLAOFK
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7E5A990", Offset = "0x7E58F90", VA = "0x187E5A990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform HIFGGDGGEAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7E464C0", Offset = "0x7E44AC0", VA = "0x187E464C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer MOHHOEAGOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7E51C80", Offset = "0x7E50280", VA = "0x187E51C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] LGIIDFMJEEH
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7E57D50", Offset = "0x7E56350", VA = "0x187E57D50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] GKBDDIGEEKE
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7E4EE20", Offset = "0x7E4D420", VA = "0x187E4EE20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator CFHNIPIOHKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D1C0", Offset = "0x7E4B7C0", VA = "0x187E4D1C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK IKOCHGKLADM
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7E4ED20", Offset = "0x7E4D320", VA = "0x187E4ED20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private IFLOKEAOLMB HOEODABCGPD
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F350", Offset = "0x7E4D950", VA = "0x187E4F350")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private IFLOKEAOLMB CEGOGKNOJEN
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7E5BB00", Offset = "0x7E5A100", VA = "0x187E5BB00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private IFLOKEAOLMB LMANEJACODE
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4B310", Offset = "0x7E49910", VA = "0x187E4B310")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private IFLOKEAOLMB DDOANNELLEF
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7E57330", Offset = "0x7E55930", VA = "0x187E57330")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private IFLOKEAOLMB MJLDOCLKJFD
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7E56D10", Offset = "0x7E55310", VA = "0x187E56D10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private IFLOKEAOLMB FMENNCGHKML
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7E54200", Offset = "0x7E52800", VA = "0x187E54200")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private IFLOKEAOLMB NCNPOOIKEJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7E590E0", Offset = "0x7E576E0", VA = "0x187E590E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private IFLOKEAOLMB DIKNOKGAEOF
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7E591E0", Offset = "0x7E577E0", VA = "0x187E591E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public KBJHHPNGGLL AMBIBIBEBNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F450", Offset = "0x7E4DA50", VA = "0x187E4F450", Slot = "16")]
		get
		{
			return default(KBJHHPNGGLL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public ABICHDKCLFP CMKKHJNEBBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAF9CC0", Offset = "0xAF82C0", VA = "0x180AF9CC0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public JMNHGNDLFHB IFCCJECNCOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAF9CB0", Offset = "0xAF82B0", VA = "0x180AF9CB0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public BNINFAJBEOF MLGHPNPGFNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB733D0", Offset = "0xB719D0", VA = "0x180B733D0", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public BNINFAJBEOF OIPLBKOGFHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAF9F60", Offset = "0xAF8560", VA = "0x180AF9F60", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string FKMEBFFPAOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA47DE0", Offset = "0xA463E0", VA = "0x180A47DE0", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform DIDPGIOKPEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7E57F40", Offset = "0x7E56540", VA = "0x187E57F40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform OOICMJBGGHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7E5D470", Offset = "0x7E5BA70", VA = "0x187E5D470")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform JAOMOKHKAHK
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7E54CB0", Offset = "0x7E532B0", VA = "0x187E54CB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform PACFPPFLMFE
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7E57430", Offset = "0x7E55A30", VA = "0x187E57430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform HEJICCKMFNB
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A1B0", Offset = "0x7E487B0", VA = "0x187E4A1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool HLNDDPGDCMA
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7E466C0", Offset = "0x7E44CC0", VA = "0x187E466C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool OODPOGMIJIF
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7E466C0", Offset = "0x7E44CC0", VA = "0x187E466C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool EMOCDLFJDFK
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7E54830", Offset = "0x7E52E30", VA = "0x187E54830")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform LHBFBAGDOHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7E4A960", Offset = "0x7E48F60", VA = "0x187E4A960")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject KGMBEOBCDCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7E4CF10", Offset = "0x7E4B510", VA = "0x187E4CF10", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets HMBNMMDALKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7E4AF40", Offset = "0x7E49540", VA = "0x187E4AF40", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform HHBHNIFJNME
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB73D60", Offset = "0xB72360", VA = "0x180B73D60", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform AJFBKCPGILF
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB732D0", Offset = "0xB718D0", VA = "0x180B732D0", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform GCBKOFJNMCH
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB60BB0", Offset = "0xB5F1B0", VA = "0x180B60BB0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform AJGJINEDBCK
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB73D00", Offset = "0xB72300", VA = "0x180B73D00", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 ECLIIKPOKEP
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7E58E60", Offset = "0x7E57460", VA = "0x187E58E60", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float GPMLHHCJOMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7E578A0", Offset = "0x7E55EA0", VA = "0x187E578A0", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform JOOICJNHFPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7E5E410", Offset = "0x7E5CA10", VA = "0x187E5E410", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform BLBHNOEOEKP
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x14EC9F0", Offset = "0x14EAFF0", VA = "0x1814EC9F0", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform OKEGBMPNDPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EADA0", VA = "0x1814EC7A0", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform HJECPNOLMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAF9EE0", Offset = "0xAF84E0", VA = "0x180AF9EE0", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool CMIMJJGGOOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7E463D0", Offset = "0x7E449D0", VA = "0x187E463D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public IAJLDMLJHLB<LFDHGFIANLC.MABBOMHIPJH> OJHJMBJGAIK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7E4F560", Offset = "0x7E4DB60", VA = "0x187E4F560", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool GCIOBKCLKBL
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7E5CBE0", Offset = "0x7E5B1E0", VA = "0x187E5CBE0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool CMMLNMKPCDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7E4D140", Offset = "0x7E4B740", VA = "0x187E4D140")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F5F0", Offset = "0x7E4DBF0", VA = "0x187E4F5F0")]
	private float HMABJFIPNCL(OAPPBGEGIHB IMADILDDNEJ, float ELEOKLMJFLE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7E54CE0", Offset = "0x7E532E0", VA = "0x187E54CE0")]
	private void KDKNOPJPCEI([In] GBNAHHBJLGF MFCIILGNAEA, [In] AvatarFullBodyConfiguration HHBGHAKIGCN, bool KANBMDBKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7E567C0", Offset = "0x7E54DC0", VA = "0x187E567C0")]
	private float KEENIIBLMNM([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7E48A50", Offset = "0x7E47050", VA = "0x187E48A50")]
	private float CDMBCLOPDMK([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A1F0", Offset = "0x7E487F0", VA = "0x187E4A1F0")]
	private void DENNJNAFLKG(GBNAHHBJLGF MFCIILGNAEA, AvatarFullBodyConfiguration HHBGHAKIGCN, bool KANBMDBKFBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D2C0", Offset = "0x7E4B8C0", VA = "0x187E4D2C0")]
	private void GBAFGKDAEOI([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7E49DD0", Offset = "0x7E483D0", VA = "0x187E49DD0")]
	private void CLMLDLCBLKO([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7E5F760", Offset = "0x7E5DD60", VA = "0x187E5F760")]
	public EKGGAKAHBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7E53AF0", Offset = "0x7E520F0", VA = "0x187E53AF0", Slot = "13")]
	public void JEHBOIAFJCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7E52A80", Offset = "0x7E51080", VA = "0x187E52A80", Slot = "14")]
	public void IGAKMNGEHEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B830", Offset = "0x7E59E30", VA = "0x187E5B830", Slot = "15")]
	public void NLFIJPFGKGO(bool GKFAIBNFDDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7E5AC70", Offset = "0x7E59270", VA = "0x187E5AC70", Slot = "26")]
	public Transform NJIOEANNHAO(string LNGMNNMFDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D6B0", Offset = "0x7E4BCB0", VA = "0x187E4D6B0", Slot = "27")]
	public Vector3? GBFOGCNKCJK(string LNGMNNMFDII)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7E575F0", Offset = "0x7E55BF0", VA = "0x187E575F0", Slot = "7")]
	public void KOGHNCKIFNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7E5CD20", Offset = "0x7E5B320", VA = "0x187E5CD20")]
	private void OGPLJAEELBC(AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7E48810", Offset = "0x7E46E10", VA = "0x187E48810", Slot = "8")]
	public void CBKGCDNCIDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7E58EF0", Offset = "0x7E574F0", VA = "0x187E58EF0")]
	private void LOIIIKLFKHP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7E53120", Offset = "0x7E51720", VA = "0x187E53120")]
	private Vector3 ILHGKIOIPMN([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B900", Offset = "0x7E59F00", VA = "0x187E5B900", Slot = "6")]
	public void NMKGHCKMCOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7E592E0", Offset = "0x7E578E0", VA = "0x187E592E0")]
	private void MNAKHHLPHFK(bool KANBMDBKFBL, MPHPPPEJPCG NIELIPLLMGC, AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7E49A90", Offset = "0x7E48090", VA = "0x187E49A90", Slot = "9")]
	public void CICCMKEDOMF(float DBGLDKFOCDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EF80", Offset = "0x7E4D580", VA = "0x187E4EF80")]
	private void HAKHDCGIEKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F610", Offset = "0x7E4DC10", VA = "0x187E4F610", Slot = "4")]
	public void HNCIHDDIFNB(string IMCDAOINJPM, BKGEJPIHGBJ MOJEBDILJCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E4A0", Offset = "0x7E4CAA0", VA = "0x187E4E4A0", Slot = "5")]
	public void GGDKPMBIGDD(KBJHHPNGGLL GKOGONKFHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7E546D0", Offset = "0x7E52CD0", VA = "0x187E546D0", Slot = "12")]
	public void JKCOKAFNDKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AA60", Offset = "0x7E49060", VA = "0x187E4AA60", Slot = "25")]
	public void EFGLPALIMLJ([Out] Vector3 JDECPLEKDAL, [Out] Quaternion FAHLMLCALBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EF20", Offset = "0x7E4D520", VA = "0x187E4EF20")]
	private void GNNNOJJKDCN([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7E5AC60", Offset = "0x7E59260", VA = "0x187E5AC60", Slot = "28")]
	public void NIGIGFEMAJG(float ODOJCJKGEIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E920", Offset = "0x7E4CF20", VA = "0x187E4E920", Slot = "29")]
	public void GHHMIDOOAFD(float NBAJMJAGFLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7E532A0", Offset = "0x7E518A0", VA = "0x187E532A0", Slot = "46")]
	public void JAGLKIGHONK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7E58FF0", Offset = "0x7E575F0", VA = "0x187E58FF0", Slot = "30")]
	public void MBBMOELAFOD(bool GLAGKJBAFDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DF00", Offset = "0x7E5C500", VA = "0x187E5DF00", Slot = "31")]
	public HandLogicOffsets PFFDMAHPICP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7E5CC60", Offset = "0x7E5B260", VA = "0x187E5CC60", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets OELGLIIHFML()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7E59DE0", Offset = "0x7E583E0", VA = "0x187E59DE0")]
	private void NBCGIDCNIDK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A210", Offset = "0x7E58810", VA = "0x187E5A210")]
	private void NFJBJEBKALI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7E48AD0", Offset = "0x7E470D0", VA = "0x187E48AD0")]
	private void CGDOLINFOOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7E49ED0", Offset = "0x7E484D0", VA = "0x187E49ED0")]
	private void CPJGAHBIOEG(KGNLHMPLHEM DCHONABIAFA, bool NDGGHLKMBPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7E57470", Offset = "0x7E55A70", VA = "0x187E57470")]
	private void KODDHPFOIOF(KGNLHMPLHEM DCHONABIAFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D850", Offset = "0x7E4BE50", VA = "0x187E4D850")]
	public Vector3 GBHKLIDPFCI()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B860", Offset = "0x7E49E60", VA = "0x187E4B860")]
	private void ELLGOFINJNE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F330", Offset = "0x7E4D930", VA = "0x187E4F330")]
	private void HEJGLNCLIMK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7E587B0", Offset = "0x7E56DB0", VA = "0x187E587B0")]
	private void LKLBJDIKOEA(GBNAHHBJLGF MFCIILGNAEA, AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7E46220", Offset = "0x7E44820", VA = "0x187E46220")]
	private float AHAAOCNBMOG([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7E5EB40", Offset = "0x7E5D140", VA = "0x187E5EB40")]
	private int PPPMGGFHFDD([In] EBHBKNGOIED KDGOKAMKDEM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E470", Offset = "0x7E5CA70", VA = "0x187E5E470")]
	private void PLCEPABFFDE(GBNAHHBJLGF MFCIILGNAEA, bool ABNBMKCLKFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BB50", Offset = "0x7E4A150", VA = "0x187E4BB50")]
	private static void ENALNLHAEKD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7E51D80", Offset = "0x7E50380", VA = "0x187E51D80")]
	private static void IEFIDLJCAOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7E5AA90", Offset = "0x7E59090", VA = "0x187E5AA90")]
	private float NGCMNHABHGE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EF50", Offset = "0x7E4D550", VA = "0x187E4EF50")]
	private static int GOEHFBAIDCN(EKGGAKAHBGP DBDIOGELIIH, EKGGAKAHBGP LHANOGJMGBN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7E4ADF0", Offset = "0x7E493F0", VA = "0x187E4ADF0", Slot = "41")]
	public GBNAHHBJLGF EFHIMBHFHGP()
	{
		return default(GBNAHHBJLGF);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EC70", Offset = "0x7E4D270", VA = "0x187E4EC70")]
	private bool GHHNPEHIHBC(int HLIPPIOIAJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7E49D50", Offset = "0x7E48350", VA = "0x187E49D50")]
	public void CKKKBADEOIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7E46040", Offset = "0x7E44640", VA = "0x187E46040")]
	private (bool, bool) AGBNDOCBFNJ()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7E46710", Offset = "0x7E44D10", VA = "0x187E46710")]
	private (float, float) BENHCCELENP([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7E468F0", Offset = "0x7E44EF0", VA = "0x187E468F0")]
	private void BIAKHBAOBOJ([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7E59AC0", Offset = "0x7E580C0", VA = "0x187E59AC0")]
	private void MNFLEHEFNMK([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C7C0", Offset = "0x7E5ADC0", VA = "0x187E5C7C0")]
	private void OEIJIDDCIBD([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN, AvatarFootSettings FEFEDOOKKAF, bool BEFGFFEKJMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7E4F570", Offset = "0x7E4DB70", VA = "0x187E4F570")]
	private float HKJPODBMKNJ()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7E48F10", Offset = "0x7E47510", VA = "0x187E48F10")]
	private void CGLIBAKAOFP(GBNAHHBJLGF DCPJOMEJHIO, AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A760", Offset = "0x7E48D60", VA = "0x187E4A760")]
	private float DLEJCKBKPNB()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DF50", Offset = "0x7E5C550", VA = "0x187E5DF50")]
	private void PHMPEDEMICH([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7E4E1B0", Offset = "0x7E4C7B0", VA = "0x187E4E1B0")]
	private void GFMNNJCINJL([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7E59E10", Offset = "0x7E58410", VA = "0x187E59E10")]
	private void NCJBKIBBLOA([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7E5DC70", Offset = "0x7E5C270", VA = "0x187E5DC70")]
	private void PDEEPAALKAB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A380", Offset = "0x7E48980", VA = "0x187E4A380")]
	private void DHKNOIODDKP(float LJNMIPKLIKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7E4CFB0", Offset = "0x7E4B5B0", VA = "0x187E4CFB0")]
	private void FNONDHMPBHP([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7E54920", Offset = "0x7E52F20", VA = "0x187E54920")]
	private void JPAIPNBEMJG(ILAJJMPAFDF CONGFPOPBMC, IKSolverVR.Arm IKKLKMPEEDN, Transform LMAKKMLBHIE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D9F0", Offset = "0x7E4BFF0", VA = "0x187E4D9F0")]
	private void GBNOHFINNNI(GBNAHHBJLGF DCPJOMEJHIO, AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7E578F0", Offset = "0x7E55EF0", VA = "0x187E578F0")]
	private void LBCIFBGOHEF(MIALFHJCNMG LOEMEAPKHEI, BNINFAJBEOF CONGFPOPBMC, IKSolverVR.Arm IKKLKMPEEDN, float CKBNHNBBPOB, float GDCMIAMPPKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7E53FF0", Offset = "0x7E525F0", VA = "0x187E53FF0")]
	private void JGEMGPDCOMB([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7E5A390", Offset = "0x7E58990", VA = "0x187E5A390")]
	private void NFMEHGJGAGB([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7E5C400", Offset = "0x7E5AA00", VA = "0x187E5C400")]
	protected void ODHHLIJAGBJ([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7E4AFC0", Offset = "0x7E495C0", VA = "0x187E4AFC0")]
	private void EHDLKKHEPOL([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7E49B00", Offset = "0x7E48100", VA = "0x187E49B00")]
	protected void CKFBLHPPGGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7E57F90", Offset = "0x7E56590", VA = "0x187E57F90")]
	private void LJNLLBPBFHL([In] GBNAHHBJLGF DCPJOMEJHIO, [In] MPHPPPEJPCG NIELIPLLMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7E4A7B0", Offset = "0x7E48DB0", VA = "0x187E4A7B0")]
	private void DNBKCLAAHIN(GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7E57F00", Offset = "0x7E56500", VA = "0x187E57F00")]
	private void LHEPHFKCMKA([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7E56E10", Offset = "0x7E55410", VA = "0x187E56E10")]
	private Vector3 KIODGNMAEOJ([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D3A0", Offset = "0x7E5B9A0", VA = "0x187E5D3A0")]
	private void OHIJDKAGBLD([In] GBNAHHBJLGF DCPJOMEJHIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7E4B410", Offset = "0x7E49A10", VA = "0x187E4B410")]
	private float ELCFAKEPPAP(float LKBKAIKOJCM, [In] GBNAHHBJLGF DCPJOMEJHIO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4D8A0", Offset = "0x7E4BEA0", VA = "0x187E4D8A0")]
	private void GBIDDAJNMEP(float LKBKAIKOJCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7E4BE10", Offset = "0x7E4A410", VA = "0x187E4BE10")]
	private void FDJMHPAKKGC([In] GBNAHHBJLGF DCPJOMEJHIO, MPHPPPEJPCG NIELIPLLMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7E5BC00", Offset = "0x7E5A200", VA = "0x187E5BC00")]
	private float OANDLOMJEBN([In] GBNAHHBJLGF MFCIILGNAEA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7E532F0", Offset = "0x7E518F0", VA = "0x187E532F0")]
	private void JDGBMMJBALA(GBNAHHBJLGF DCPJOMEJHIO, MPHPPPEJPCG NIELIPLLMGC, Vector3 LDGMHLHDOKC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7E48550", Offset = "0x7E46B50", VA = "0x187E48550")]
	private static void BMCJJEFKBJK(Transform DFOHJKCGEGI, Quaternion CFFPEJBOBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7E4DEB0", Offset = "0x7E4C4B0", VA = "0x187E4DEB0")]
	private void GEPEOKKGOAH([In] GBNAHHBJLGF EDDFGMDJIME, [In] EBHBKNGOIED KDGOKAMKDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7E5ADC0", Offset = "0x7E593C0", VA = "0x187E5ADC0")]
	private void NKGAIFCONNI([In] GBNAHHBJLGF EDDFGMDJIME, [In] EBHBKNGOIED KDGOKAMKDEM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7E45E50", Offset = "0x7E44450", VA = "0x187E45E50")]
	private void AFLMOGGGMLM(float AGADDGNGNGI, [In] GBNAHHBJLGF MFCIILGNAEA, float ELLCOFECFBE = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7E5D4B0", Offset = "0x7E5BAB0", VA = "0x187E5D4B0")]
	private float OOMCBLAGNJP([In] GBNAHHBJLGF MFCIILGNAEA, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7E52E30", Offset = "0x7E51430", VA = "0x187E52E30")]
	private void ILGBEBCPHLO([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7E4C500", Offset = "0x7E4AB00", VA = "0x187E4C500")]
	private void FEIJAMCNMGK([In] GBNAHHBJLGF MFCIILGNAEA, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7E54300", Offset = "0x7E52900", VA = "0x187E54300")]
	private void JHHIJFNAMFB([In] GBNAHHBJLGF MFCIILGNAEA, float PIDMMAFJJBB, float LGDMKNANAJE, Vector3 GAGEFECJBMF, float ELLCOFECFBE = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7E45460", Offset = "0x7E43A60", VA = "0x187E45460")]
	private void ABNELOCOAMO(GBNAHHBJLGF MFCIILGNAEA, AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7E57AC0", Offset = "0x7E560C0", VA = "0x187E57AC0")]
	private void LBELDCDGEMP(GBNAHHBJLGF DCPJOMEJHIO, AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7E56850", Offset = "0x7E54E50", VA = "0x187E56850")]
	private void KGJGHAGNHJF(GBNAHHBJLGF MFCIILGNAEA, AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7E5B670", Offset = "0x7E59C70", VA = "0x187E5B670")]
	public void NLAJDIOLFNE([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7E4EFD0", Offset = "0x7E4D5D0", VA = "0x187E4EFD0")]
	public void HDKIFMKCHCM([In] GBNAHHBJLGF DCPJOMEJHIO, [In] AvatarFullBodyConfiguration HHBGHAKIGCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7E5E9A0", Offset = "0x7E5CFA0", VA = "0x187E5E9A0")]
	[CompilerGenerated]
	internal static void PNNKMEONAAE(Transform LFMKIINCPNH, IKSolverVR.Arm IKKLKMPEEDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7E57E50", Offset = "0x7E56450", VA = "0x187E57E50")]
	[CompilerGenerated]
	internal static void LEGKDIOIEMI(Vector3 BLFCHGEBGOF, Vector3 JHNGBNKPDEK, MPOMANCIBJJ P_2, HECNPEMEFID P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7E59040", Offset = "0x7E57640", VA = "0x187E59040")]
	[CompilerGenerated]
	internal static void MBJOMLMGJPK(DBMEJBJDJFM KHBCGLCPDKF, DBMEJBJDJFM OBHJPHPCKOC, Vector3 BCJAAEMHDKD, float NNDNCFBMBFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7E48700", Offset = "0x7E46D00", VA = "0x187E48700")]
	[CompilerGenerated]
	internal static bool BMDPGMBFMHC(IKSolverVR.Arm IKKLKMPEEDN, CAHOOEDAEGA BBGDKDCBDON, float BIAOBEINLAM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7E51840", Offset = "0x7E4FE40", VA = "0x187E51840")]
	[CompilerGenerated]
	internal static float HPEHBMFPKCB(Vector3 LNGCLPDMDAB, Vector3 LLENEODHLJL, Vector3 AEICDPNOAIA, GBNAHHBJLGF MFCIILGNAEA, AvatarFullBodyConfiguration HHBGHAKIGCN, float MOBKDJHFHDL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class DOLAMHEDJAA : NNKDNMIHNII
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, LFDHGFIANLC> IPKCCBICJMM;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7E62B90", Offset = "0x7E61190", VA = "0x187E62B90")]
	[BNHIEDNKDNA.MLFEBCDGLFC]
	internal static void IJBKJEMLLLN(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7E62790", Offset = "0x7E60D90", VA = "0x187E62790", Slot = "4")]
	public LFDHGFIANLC CBBJFMNEHCD(string CMCPEBOOGHD, AvatarSystemConfiguration LDAJNIFIIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7E629B0", Offset = "0x7E60FB0", VA = "0x187E629B0", Slot = "5")]
	public void GOMPFPKJAFN(string CMCPEBOOGHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7E62C00", Offset = "0x7E61200", VA = "0x187E62C00", Slot = "6")]
	public string JAAAFMPJNPF(string AJGKGCGFHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7E62D40", Offset = "0x7E61340", VA = "0x187E62D40")]
	private string JOCCLAKHCNO(string AJGKGCGFHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7E62DB0", Offset = "0x7E613B0", VA = "0x187E62DB0")]
	public DOLAMHEDJAA()
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
		public class ONPNONPNDGH
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> LKJDIFNGNKM;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool NGPOKKIJIOI
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x7E6ABD0", Offset = "0x7E691D0", VA = "0x187E6ABD0")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7E6AC10", Offset = "0x7E69210", VA = "0x187E6AC10")]
			public void KCPGNJNLGAH(VRIK HIFKDNCDMDO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA469F0", Offset = "0xA44FF0", VA = "0x180A469F0")]
			public void DOBDDMJJFIG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7E6AD40", Offset = "0x7E69340", VA = "0x187E6AD40")]
			public void MGCNIAHBIMM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7E6AD90", Offset = "0x7E69390", VA = "0x187E6AD90")]
			public ONPNONPNDGH()
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
		[PPBMPHDDNEA(CNNBEEFOMHL.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[DOIDGFGIDBO(CNNBEEFOMHL.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly ONPNONPNDGH GGIOJNHELPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private BDOEGNKBLLO BGJFLAELNPJ;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7E60AF0", Offset = "0x7E5F0F0", VA = "0x187E60AF0")]
		private void FLMOPKJJIJF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7E60DD0", Offset = "0x7E5F3D0", VA = "0x187E60DD0")]
		private bool NINPJEJLGEK()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7E60E20", Offset = "0x7E5F420", VA = "0x187E60E20")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7E60E90", Offset = "0x7E5F490", VA = "0x187E60E90")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7E60E30", Offset = "0x7E5F430", VA = "0x187E60E30")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7E61100", Offset = "0x7E5F700", VA = "0x187E61100")]
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
			[Cpp2IlInjected.Address(RVA = "0x7E659A0", Offset = "0x7E63FA0", VA = "0x187E659A0")]
			public (float, float) FEGMGCIGINJ(float NJMJJDGEHOL)
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
				[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7E651D0", Offset = "0x7E637D0", VA = "0x187E651D0")]
			public void PNLBMDNIIGG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7E65090", Offset = "0x7E63690", VA = "0x187E65090")]
			public (float, float) FLFHKNEADDG(Animator LCJPNLPLMDG, AnimatorStateInfo FAENHKINOMC)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E65750", Offset = "0x7E63D50", VA = "0x187E65750")]
		public void PNLBMDNIIGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7E652B0", Offset = "0x7E638B0", VA = "0x187E652B0")]
		public (float, float) GMELKNMDMLF(Animator LCJPNLPLMDG, OAPPBGEGIHB IMADILDDNEJ, float OJEJKHINCKL)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7E654F0", Offset = "0x7E63AF0", VA = "0x187E654F0")]
		private (float, float) LFHFHDPCDOH(Animator LCJPNLPLMDG, AnimatorStateInfo FAENHKINOMC, OAPPBGEGIHB IMADILDDNEJ, float OJEJKHINCKL)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7E65990", Offset = "0x7E63F90", VA = "0x187E65990")]
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
		[Cpp2IlInjected.Address(RVA = "0x7E6AA40", Offset = "0x7E69040", VA = "0x187E6AA40", Slot = "4")]
		public override void OnStateEnter(Animator LCJPNLPLMDG, AnimatorStateInfo FAENHKINOMC, int ILJBMEICFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7E6ABB0", Offset = "0x7E691B0", VA = "0x187E6ABB0")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class LOMOGAHLPOC<TInput, TOutput> : CLFIHJNCEEK<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly HJILBECDIFL KOFKJMOGEGK;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x54388B0", Offset = "0x5436EB0", VA = "0x1854388B0")]
	protected LOMOGAHLPOC(HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput FJJOMODMCLM(TInput FCHACHIDAGA, [Out] IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x5438810", Offset = "0x5436E10", VA = "0x185438810", Slot = "5")]
	public bool HKHHCIJDPPA(TInput FCHACHIDAGA, [Out] TOutput? HPCDHGHHCOO, [Out] IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[HIAEMPMDAHB]
public static class DJLCMJIFKAO
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex DHJLOKMFAJO;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7E624E0", Offset = "0x7E60AE0", VA = "0x187E624E0")]
	public static LFIBBDBIFPE HDLHGMAHPAL(OLAHBCMDBEM KBPGIMIOBMD, ALBLDJNNKOA BDFEINHODFG, Guid? BCMAFCIPNGO, Color? HFPGBDHLKMG, JBDCJHGBANL HJLDIJBMLBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7E62230", Offset = "0x7E60830", VA = "0x187E62230")]
	public static KAMKFCKINLN BEBAACLAEGK(LFIBBDBIFPE ACJFHCNBBBO)
	{
		return default(KAMKFCKINLN);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3998BC0", Offset = "0x39971C0", VA = "0x183998BC0")]
	internal static TModern? MBJFDLGIHNG<TModern>(string? FCHACHIDAGA, LNCPLAGEFJB<TModern> IIGAKCGLCLF, HJILBECDIFL KOFKJMOGEGK, LOAGDCNPCOP KNGOHPIJOFD, TModern DEPJCKEOIGD) where TModern : struct, FOAALLIHHLC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3998450", Offset = "0x3996A50", VA = "0x183998450")]
	internal static MEEPFHGKCMP FHNKFPLCGCA<TModern>(string? FCHACHIDAGA, LNCPLAGEFJB<TModern> IIGAKCGLCLF, HJILBECDIFL KOFKJMOGEGK, LOAGDCNPCOP KNGOHPIJOFD, TModern DEPJCKEOIGD) where TModern : struct, FOAALLIHHLC
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7E62390", Offset = "0x7E60990", VA = "0x187E62390")]
	internal static List<MDMFDAOEDCK> FCMDIBENFNF(IEnumerable<FEDPMHOLDJI>? EPJMCAFPPOI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x399A210", Offset = "0x3998810", VA = "0x18399A210")]
	internal static string PFENHADMBOH<TModern>(TModern FCHACHIDAGA, LNCPLAGEFJB<TModern> IIGAKCGLCLF, HJILBECDIFL KOFKJMOGEGK) where TModern : FOAALLIHHLC
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class LEMKAKBNMCL : OGDMIODCIAH
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public CLFIHJNCEEK<NMEEMBGLHAM, JMOEBMFNCHJ> HKPAGKINHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA44400", Offset = "0xA42A00", VA = "0x180A44400", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public CLFIHJNCEEK<EMANPBGJAME, JACLIKLBEMH> CMGHDDFHLAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public CLFIHJNCEEK<EMANPBGJAME, JACLIKLBEMH> IBOGLPHPOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA45140", Offset = "0xA43740", VA = "0x180A45140", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public KPNAJFMGPIP DJKOLOHIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA47BE0", Offset = "0xA461E0", VA = "0x180A47BE0", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public JPDCJMDLLLD GNEOAHHFNDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7E68C30", Offset = "0x7E67230", VA = "0x187E68C30")]
	[BNHIEDNKDNA.MLFEBCDGLFC.CIEDAEOKGHH]
	[UsedImplicitly]
	internal static void LIOLFPLPJOM(DCNOMJHNEOK FAIEEFHMPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7E68CA0", Offset = "0x7E672A0", VA = "0x187E68CA0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal LEMKAKBNMCL([GGNLMCAPMLP("UnitySerialization")] DPHALFOLFDB JCNPBPAFJFG, [GGNLMCAPMLP(null)] LGKJIPCELAF PONOHPHOPGC, [GGNLMCAPMLP(null)] HJILBECDIFL KOFKJMOGEGK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum DDHNEGDCKFO
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
public class FACEFEIDEBI : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7E62EE0", Offset = "0x7E614E0", VA = "0x187E62EE0")]
	public FACEFEIDEBI(string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7E62EB0", Offset = "0x7E614B0", VA = "0x187E62EB0")]
	public FACEFEIDEBI(string CJIMOMNMAGD, Exception OGLKKFPLOGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7E62E40", Offset = "0x7E61440", VA = "0x187E62E40")]
	public FACEFEIDEBI(DDHNEGDCKFO EFGKEPFKHGG, string CJIMOMNMAGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7E62E70", Offset = "0x7E61470", VA = "0x187E62E70")]
	public FACEFEIDEBI(DDHNEGDCKFO EFGKEPFKHGG, string CJIMOMNMAGD, Exception OGLKKFPLOGF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class GHCBCEKEIKK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly DPHALFOLFDB JCNPBPAFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly LGKJIPCELAF PONOHPHOPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly HJILBECDIFL KOFKJMOGEGK;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7E64F10", Offset = "0x7E63510", VA = "0x187E64F10")]
	protected GHCBCEKEIKK(DPHALFOLFDB JCNPBPAFJFG, LGKJIPCELAF PONOHPHOPGC, HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7E638E0", Offset = "0x7E61EE0", VA = "0x187E638E0")]
	protected string FPECIFDHNGK(JMOEBMFNCHJ NHMMIOKPODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7E636F0", Offset = "0x7E61CF0", VA = "0x187E636F0")]
	protected string EJBLNJEEIND(JMOEBMFNCHJ NHMMIOKPODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7E64BE0", Offset = "0x7E631E0", VA = "0x187E64BE0")]
	private AvatarOutfitSelectionData HDLHGMAHPAL(LFIBBDBIFPE MMGLJKOEKKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7E635B0", Offset = "0x7E61BB0", VA = "0x187E635B0")]
	private static AvatarCustomizationSettingsData.AnchorParams AFELNFAKFIM(AFNDLFBCDPE? OLIBKDAKDPC)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface CLFIHJNCEEK<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput FJJOMODMCLM(TInput FCHACHIDAGA, [Out] IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool HKHHCIJDPPA(TInput FCHACHIDAGA, [Out] TOutput? HPCDHGHHCOO, [Out] IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface OGDMIODCIAH
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	CLFIHJNCEEK<NMEEMBGLHAM, JMOEBMFNCHJ> HKPAGKINHGC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	CLFIHJNCEEK<EMANPBGJAME, JACLIKLBEMH> IBOGLPHPOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	KPNAJFMGPIP DJKOLOHIHCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum LOAGDCNPCOP
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface JPDCJMDLLLD
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	KOIECIFOAMK LGGJGPOGIBH(JMOEBMFNCHJ ACJFHCNBBBO);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface KPNAJFMGPIP
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	EMANPBGJAME LGGJGPOGIBH(JMOEBMFNCHJ ACJFHCNBBBO, int EHGJOAMMNGG, string? IEDAJGLJHNI, string? JHAGCIKJBEG, JHEMHCNCGNK CEHECLIMMGG, List<MDMFDAOEDCK>? NGAFGAMLNEC);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[HIAEMPMDAHB]
internal class PFFFPKJFBHM : LOMOGAHLPOC<NMEEMBGLHAM, JMOEBMFNCHJ>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly LGKJIPCELAF PONOHPHOPGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly JBHAKKIGGGO GCLAAHJGLPE;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B5D0", Offset = "0x7E69BD0", VA = "0x187E6B5D0")]
	public PFFFPKJFBHM(DPHALFOLFDB JCNPBPAFJFG, LGKJIPCELAF PONOHPHOPGC, HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7E6B320", Offset = "0x7E69920", VA = "0x187E6B320", Slot = "6")]
	public override JMOEBMFNCHJ FJJOMODMCLM(NMEEMBGLHAM FCHACHIDAGA, [Out] IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class MKCGFECFKGN : DPHALFOLFDB
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class FOFGNCNFDPN : JsonConverter<MEEPFHGKCMP>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7E634D0", Offset = "0x7E61AD0", VA = "0x187E634D0", Slot = "9")]
		public override void WriteJson(JsonWriter DCGAFNKBAGF, MEEPFHGKCMP? KKGBKLFKCPO, JsonSerializer ABKNIBKILDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7E633B0", Offset = "0x7E619B0", VA = "0x187E633B0", Slot = "10")]
		public override MEEPFHGKCMP ReadJson(JsonReader KMBIKKJCMFN, Type GJMKDBPNFOO, MEEPFHGKCMP? BIKEPCPNLDG, bool MKOODLFMLLF, JsonSerializer ABKNIBKILDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7E63570", Offset = "0x7E61B70", VA = "0x187E63570")]
		public FOFGNCNFDPN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class PCCMINILFOE : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool HIOJKAADBLO
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA90450", Offset = "0xA8EA50", VA = "0x180A90450", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7E6B1E0", Offset = "0x7E697E0", VA = "0x187E6B1E0", Slot = "5")]
		public override object ReadJson(JsonReader KMBIKKJCMFN, Type GJMKDBPNFOO, object? BIKEPCPNLDG, JsonSerializer ABKNIBKILDN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7E6AE20", Offset = "0x7E69420", VA = "0x187E6AE20", Slot = "6")]
		public override bool CanConvert(Type GJMKDBPNFOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7E6B240", Offset = "0x7E69840", VA = "0x187E6B240", Slot = "4")]
		public override void WriteJson(JsonWriter DCGAFNKBAGF, object? KKGBKLFKCPO, JsonSerializer ABKNIBKILDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7E6B000", Offset = "0x7E69600", VA = "0x187E6B000")]
		private static bool LLBJAFEJKED(object KKGBKLFKCPO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA6F950", Offset = "0xA6DF50", VA = "0x180A6F950")]
		public PCCMINILFOE()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings IKFHIBIOKMD;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7E6A8E0", Offset = "0x7E68EE0", VA = "0x187E6A8E0")]
	internal MKCGFECFKGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E030", Offset = "0x3C1C630", VA = "0x183C1E030", Slot = "4")]
	public string HIFAAAJCJMB<T>(T ODCICEDDLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3C1E090", Offset = "0x3C1C690", VA = "0x183C1E090", Slot = "5")]
	public T LIJPLCHILPJ<T>(string KKGBKLFKCPO)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class EMPNIIJOFBD : DPHALFOLFDB
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x39CD720", Offset = "0x39CBD20", VA = "0x1839CD720", Slot = "4")]
	public string HIFAAAJCJMB<T>(T ODCICEDDLMB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x39CD780", Offset = "0x39CBD80", VA = "0x1839CD780", Slot = "5")]
	public T LIJPLCHILPJ<T>(string KKGBKLFKCPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
	public EMPNIIJOFBD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[HIAEMPMDAHB]
internal class JBHAKKIGGGO : LOMOGAHLPOC<EMANPBGJAME, JACLIKLBEMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly DPHALFOLFDB JCNPBPAFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly LGKJIPCELAF PONOHPHOPGC;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7E67ED0", Offset = "0x7E664D0", VA = "0x187E67ED0")]
	public JBHAKKIGGGO(DPHALFOLFDB JCNPBPAFJFG, LGKJIPCELAF PONOHPHOPGC, HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7E66110", Offset = "0x7E64710", VA = "0x187E66110", Slot = "6")]
	public override JACLIKLBEMH FJJOMODMCLM(EMANPBGJAME FCHACHIDAGA, [Out] IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7E66A40", Offset = "0x7E65040", VA = "0x187E66A40")]
	internal void KAIBCBNPMFI(string PLBGOKFMBOC, JMOEBMFNCHJ NHMMIOKPODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7E67580", Offset = "0x7E65B80", VA = "0x187E67580")]
	public IEnumerable<LFIBBDBIFPE> OHENKICEDED(string LBPJNHGHNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7E66B90", Offset = "0x7E65190", VA = "0x187E66B90")]
	private IEnumerable<LFIBBDBIFPE> LODAAMFBHPB(string LBPJNHGHNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7E67110", Offset = "0x7E65710", VA = "0x187E67110")]
	internal IEnumerable<LFIBBDBIFPE> NPPKDNIFOJG(string LBPJNHGHNOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7E65D80", Offset = "0x7E64380", VA = "0x187E65D80")]
	private LFIBBDBIFPE DAMMGFKKMLC(AvatarOutfitSelectionData BDPAOPMIIOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7E67630", Offset = "0x7E65C30", VA = "0x187E67630")]
	private void PFDJHIMLFNC(AvatarCustomizationSettingsData ALDBCAILKEB, JMOEBMFNCHJ NHMMIOKPODG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7E65A60", Offset = "0x7E64060", VA = "0x187E65A60")]
	private LFIBBDBIFPE DAMMGFKKMLC(string IKNJNCLIDBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7E66740", Offset = "0x7E64D40", VA = "0x187E66740")]
	internal static (JBDCJHGBANL, string, string) GIOGJGCCNHI(string IKNJNCLIDBF, HJILBECDIFL KOFKJMOGEGK)
	{
		return default((JBDCJHGBANL, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7E66540", Offset = "0x7E64B40", VA = "0x187E66540")]
	private AJOBEKMPNIB? FJPMABBNGOK(string? PPIICOOCLEP, Vector2 JPMEFMMMMAC, float MBBFEPDGCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7E66FB0", Offset = "0x7E655B0", VA = "0x187E66FB0")]
	private static AFNDLFBCDPE MLLBGAEJBFP(AvatarCustomizationSettingsData.AnchorParams LJJFKOFOCBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[HIAEMPMDAHB]
internal class LEFFMONMHBF : GHCBCEKEIKK, JPDCJMDLLLD
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7E64F10", Offset = "0x7E63510", VA = "0x187E64F10")]
	public LEFFMONMHBF(DPHALFOLFDB JCNPBPAFJFG, LGKJIPCELAF PONOHPHOPGC, HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7E68640", Offset = "0x7E66C40", VA = "0x187E68640", Slot = "4")]
	public KOIECIFOAMK LGGJGPOGIBH(JMOEBMFNCHJ ACJFHCNBBBO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7E68540", Offset = "0x7E66B40", VA = "0x187E68540")]
	private string JJKDEFCEKJE(JMOEBMFNCHJ NHMMIOKPODG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7E689F0", Offset = "0x7E66FF0", VA = "0x187E689F0")]
	private string NNIEICHIMMI(LFIBBDBIFPE MMGLJKOEKKG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[HIAEMPMDAHB]
internal class KLLHMPLDPOC : LOMOGAHLPOC<EMANPBGJAME, JACLIKLBEMH>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly DPHALFOLFDB JCNPBPAFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly CLFIHJNCEEK<EMANPBGJAME, JACLIKLBEMH> DBDNOACBCHN;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7E68440", Offset = "0x7E66A40", VA = "0x187E68440")]
	public KLLHMPLDPOC(CLFIHJNCEEK<EMANPBGJAME, JACLIKLBEMH> DBDNOACBCHN, HJILBECDIFL KOFKJMOGEGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7E68010", Offset = "0x7E66610", VA = "0x187E68010", Slot = "6")]
	public override JACLIKLBEMH FJJOMODMCLM(EMANPBGJAME FCHACHIDAGA, [Out] IReadOnlyList<MDMFDAOEDCK>? NGAFGAMLNEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[HIAEMPMDAHB]
internal class FFPBONJJPLB : KPNAJFMGPIP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly DPHALFOLFDB JCNPBPAFJFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly JPDCJMDLLLD NKGCFGJFAJL;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7E632C0", Offset = "0x7E618C0", VA = "0x187E632C0")]
	public FFPBONJJPLB(JPDCJMDLLLD NKGCFGJFAJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7E62F10", Offset = "0x7E61510", VA = "0x187E62F10", Slot = "4")]
	public EMANPBGJAME LGGJGPOGIBH(JMOEBMFNCHJ ACJFHCNBBBO, int EHGJOAMMNGG, string? IEDAJGLJHNI, string? JHAGCIKJBEG, JHEMHCNCGNK CEHECLIMMGG, List<MDMFDAOEDCK>? NGAFGAMLNEC)
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
		[Cpp2IlInjected.Address(RVA = "0x7E60160", Offset = "0x7E5E760", VA = "0x187E60160")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA469E0", Offset = "0xA44FE0", VA = "0x180A469E0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class BMJDFDACEKG
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7E61240", Offset = "0x7E5F840", VA = "0x187E61240")]
	public static KAMKFCKINLN FJJOMODMCLM(this NOKHOFNKHOJ ACJFHCNBBBO)
	{
		return default(KAMKFCKINLN);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7E61350", Offset = "0x7E5F950", VA = "0x187E61350")]
	public static NOKHOFNKHOJ LGGJGPOGIBH(this KAMKFCKINLN NFECJEGEHFA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7E611E0", Offset = "0x7E5F7E0", VA = "0x187E611E0")]
	public static bool DHFEOOKPNLI(this KAMKFCKINLN NFECJEGEHFA)
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
			[Cpp2IlInjected.Address(RVA = "0x5F00D10", Offset = "0x5EFF310", VA = "0x185F00D10")]
			public AnchorParams(Vector2 IMLPOBMIHAI, Vector3 POKKMJBONPM, Vector3 APHPLOKDPNP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7E600B0", Offset = "0x7E5E6B0", VA = "0x187E600B0")]
			internal AFNDLFBCDPE LGGJGPOGIBH()
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
		private JNNECLPJAPF useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x7E60990", Offset = "0x7E5EF90", VA = "0x187E60990")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA45130", Offset = "0xA43730", VA = "0x180A45130")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x17784D0", Offset = "0x1776AD0", VA = "0x1817784D0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xD64DE0", Offset = "0xD633E0", VA = "0x180D64DE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xF4CDB0", Offset = "0xF4B3B0", VA = "0x180F4CDB0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x147BDF0", Offset = "0x147A3F0", VA = "0x18147BDF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA49530", Offset = "0xA47B30", VA = "0x180A49530")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA49520", Offset = "0xA47B20", VA = "0x180A49520")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7E60A40", Offset = "0x7E5F040", VA = "0x187E60A40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA47BD0", Offset = "0xA461D0", VA = "0x180A47BD0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xCBB6B0", Offset = "0xCB9CB0", VA = "0x180CBB6B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xCBB710", Offset = "0xCB9D10", VA = "0x180CBB710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4D0", Offset = "0xA4AAD0", VA = "0x180A4C4D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4B0", Offset = "0xA4AAB0", VA = "0x180A4C4B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7E60A80", Offset = "0x7E5F080", VA = "0x187E60A80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xF02DB0", Offset = "0xF013B0", VA = "0x180F02DB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x118A830", Offset = "0x1188E30", VA = "0x18118A830")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x191D580", Offset = "0x191BB80", VA = "0x18191D580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA44990", Offset = "0xA42F90", VA = "0x180A44990")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA44950", Offset = "0xA42F50", VA = "0x180A44950")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x247DA10", Offset = "0x247C010", VA = "0x18247DA10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xF2C2B0", Offset = "0xF2A8B0", VA = "0x180F2C2B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA7C640", Offset = "0xA7AC40", VA = "0x180A7C640")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA7C6A0", Offset = "0xA7ACA0", VA = "0x180A7C6A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4E0", Offset = "0xA4AAE0", VA = "0x180A4C4E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA4C4C0", Offset = "0xA4AAC0", VA = "0x180A4C4C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA4C400", Offset = "0xA4AA00", VA = "0x180A4C400")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA4C2F0", Offset = "0xA4A8F0", VA = "0x180A4C2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA4C410", Offset = "0xA4AA10", VA = "0x180A4C410")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA4C320", Offset = "0xA4A920", VA = "0x180A4C320")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xAB07D0", Offset = "0xAAEDD0", VA = "0x180AB07D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xAAF660", Offset = "0xAADC60", VA = "0x180AAF660")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA4C3C0", Offset = "0xA4A9C0", VA = "0x180A4C3C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA4C440", Offset = "0xA4AA40", VA = "0x180A4C440")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xAB0BF0", Offset = "0xAAF1F0", VA = "0x180AB0BF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xF26510", Offset = "0xF24B10", VA = "0x180F26510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA51E60", Offset = "0xA50460", VA = "0x180A51E60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA51EE0", Offset = "0xA504E0", VA = "0x180A51EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xE23A60", Offset = "0xE22060", VA = "0x180E23A60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xF2B480", Offset = "0xF29A80", VA = "0x180F2B480")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xD3D030", Offset = "0xD3B630", VA = "0x180D3D030")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xD3B2F0", Offset = "0xD398F0", VA = "0x180D3B2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public JNNECLPJAPF UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xFCF3C0", Offset = "0xFCD9C0", VA = "0x180FCF3C0")]
			get
			{
				return default(JNNECLPJAPF);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xFCEE20", Offset = "0xFCD420", VA = "0x180FCEE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xFCD950", Offset = "0xFCBF50", VA = "0x180FCD950")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC89000", Offset = "0xC87600", VA = "0x180C89000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7E60A60", Offset = "0x7E5F060", VA = "0x187E60A60")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7E60AA0", Offset = "0x7E5F0A0", VA = "0x187E60AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7E605F0", Offset = "0x7E5EBF0", VA = "0x187E605F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
		public JBDCJHGBANL BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private DJFEEPGNCGI? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA45100", Offset = "0xA43700", VA = "0x180A45100")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7E60AC0", Offset = "0x7E5F0C0", VA = "0x187E60AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA4E4C0", Offset = "0xA4CAC0", VA = "0x180A4E4C0")]
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
