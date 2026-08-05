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
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C01F90", Offset = "0x7C00990", VA = "0x187C01F90")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA35A80", Offset = "0xA34480", VA = "0x180A35A80")]
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
		[Cpp2IlInjected.Address(RVA = "0xA35AC0", Offset = "0xA344C0", VA = "0x180A35AC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C02010", Offset = "0x7C00A10", VA = "0x187C02010", Slot = "8")]
		public override void RegisterMethods(ITypeRegistration registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x2796C60", Offset = "0x2795660", VA = "0x182796C60")]
		public _AssemblyIndex()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[NHPBPJDIEFG]
internal class IFCNFMJGAJD : NMFEKPEJNPE
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	[CompilerGenerated]
	private struct NOJEOGMBKOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public IFCNFMJGAJD <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public DOOHILAACHK avatarBodyType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public AvatarConfiguration avatarConfiguration;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private readonly GNAIAFAGFIH COOLFMKCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	private readonly HJPLJLIANIE POLMBFDFMJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private readonly AAKFNIIOLKM GGOFFGNEPLC;

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7C004A0", Offset = "0x7BFEEA0", VA = "0x187C004A0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	[UsedImplicitly]
	internal static void BEEGBIHCEAF(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x7C01D70", Offset = "0x7C00770", VA = "0x187C01D70")]
	[RecRoom.NoEngine.Common.Preserve]
	internal IFCNFMJGAJD([CNHMBDDCGKB(null)] GNAIAFAGFIH COOLFMKCNIC, [CNHMBDDCGKB(null)] HJPLJLIANIE POLMBFDFMJF, [CNHMBDDCGKB(null)] AAKFNIIOLKM GGOFFGNEPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(RVA = "0x7C005A0", Offset = "0x7BFEFA0", VA = "0x187C005A0", Slot = "5")]
	public HEFJDHOHCHF CLKKDILCLKE(DOOHILAACHK IOBACPOPLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7C011F0", Offset = "0x7BFFBF0", VA = "0x187C011F0", Slot = "4")]
	public HEFJDHOHCHF MCIINGHAFFP(DOOHILAACHK IOBACPOPLDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7C010E0", Offset = "0x7BFFAE0", VA = "0x187C010E0", Slot = "6")]
	public IGPMACADNKG LBGLNKCIBFJ(HEFJDHOHCHF HPGIDELCODH, int MFGDHAHMLOE, string? GBCFHNGPBLM, string? INLJMPKJBPJ, MCOEPIIJNLA LDPGNLMNBBL, List<MOJBEEJFCOI>? FEOFNCKAHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7C01CE0", Offset = "0x7C006E0", VA = "0x187C01CE0", Slot = "7")]
	public bool PEMBGMIBLBB(GEMPBMEMGFC BGHBMILPOKK, [Out] HEFJDHOHCHF? EJPDJBEBHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7C00E60", Offset = "0x7BFF860", VA = "0x187C00E60", Slot = "8")]
	public bool FHICPKIIHBO(IGPMACADNKG PDNJDGICFMG, [Out] HEFJDHOHCHF? EJPDJBEBHDF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C00510", Offset = "0x7BFEF10", VA = "0x187C00510", Slot = "9")]
	public bool BKOIFHHHGDG(IGPMACADNKG PDNJDGICFMG, [Out] NCOIOOIHPIG? BGHBMILPOKK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x3AA35F0", Offset = "0x3AA1FF0", VA = "0x183AA35F0")]
	private bool APBMHMCKLLM<TInput, TOutput>(TInput OKFHNJPHDOP, MDPEBNNFNPI<TInput, TOutput> AOOHJEKNBBM, [Out] TOutput? MGJNMKLFKCJ) where TOutput : class
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7C00F40", Offset = "0x7BFF940", VA = "0x187C00F40")]
	[CompilerGenerated]
	private BHLDDBLCIKF IDCGAIJMEEG(FaceFeatureType ANJELGDBCJM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7C002C0", Offset = "0x7BFECC0", VA = "0x187C002C0")]
	[CompilerGenerated]
	private BHLDDBLCIKF AFKIBNLPKFB(FaceFeatureType ANJELGDBCJM, NOJEOGMBKOK P_1)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NHPBPJDIEFG]
internal class DOMKNLPOMKD : GNAIAFAGFIH
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	private delegate void FJCKICLCDDG<in TData>(TData EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON);

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	[CompilerGenerated]
	private sealed class NFBEDMNHLBL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public GAKPNEPDBDG rangeDataType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public CIHLHJIOPKJ currAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public CIHLHJIOPKJ latestAvatarVersion;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public RangeMigration? prevRange;

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
		public NFBEDMNHLBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x7C01F70", Offset = "0x7C00970", VA = "0x187C01F70")]
		internal bool KPOBGKIHOMM(RangeMigration x)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7C01EF0", Offset = "0x7C008F0", VA = "0x187C01EF0")]
		internal bool EFIPACDLIEO(RangeMigration x)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private readonly AAKFNIIOLKM GGOFFGNEPLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private readonly HEILNANPDJC MNPKNCJLCKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private readonly FJCKICLCDDG<HEFJDHOHCHF>?[] COOLFMKCNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	private readonly FJCKICLCDDG<NCOIOOIHPIG>?[] OOKGONKOEHO;

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE4C0", Offset = "0x7BFCEC0", VA = "0x187BFE4C0")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	[UsedImplicitly]
	internal static void BEEGBIHCEAF(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFC40", Offset = "0x7BFE640", VA = "0x187BFFC40")]
	[RecRoom.NoEngine.Common.Preserve]
	internal DOMKNLPOMKD([CNHMBDDCGKB(null)] AAKFNIIOLKM GGOFFGNEPLC, [CNHMBDDCGKB(null)] HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF9B0", Offset = "0x7BFE3B0", VA = "0x187BFF9B0", Slot = "4")]
	public bool NBMIIJPGICK(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFAB0", Offset = "0x7BFE4B0", VA = "0x187BFFAB0", Slot = "5")]
	public bool NBMIIJPGICK(NCOIOOIHPIG BGHBMILPOKK, IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEAB0", Offset = "0x7BFD4B0", VA = "0x187BFEAB0")]
	private void KKOBFAMPFPM(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE0C0", Offset = "0x7BFCAC0", VA = "0x187BFE0C0")]
	private void AAOOCHHONIP(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE5E0", Offset = "0x7BFCFE0", VA = "0x187BFE5E0")]
	private void EDAEOKDPNJH(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEA70", Offset = "0x7BFD470", VA = "0x187BFEA70")]
	private void IMDBJIGEKNE(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE9A0", Offset = "0x7BFD3A0", VA = "0x187BFE9A0")]
	private void GICJKNNPANH(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE530", Offset = "0x7BFCF30", VA = "0x187BFE530")]
	private void DOMHOCOBGKM(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE610", Offset = "0x7BFD010", VA = "0x187BFE610")]
	private void GEDGIBCIFKN(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BFEAA0", Offset = "0x7BFD4A0", VA = "0x187BFEAA0")]
	private void JKGCPENNIKA(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BFFC10", Offset = "0x7BFE610", VA = "0x187BFFC10")]
	private void PEMMOKPPOHO(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FHFGMILAALL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF690", Offset = "0x7BFE090", VA = "0x187BFF690")]
	private void MELMPLIACGA(HEFJDHOHCHF EJPDJBEBHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE6C0", Offset = "0x7BFD0C0", VA = "0x187BFE6C0")]
	private HEFJDHOHCHF GFPECBBDHFJ(HEFJDHOHCHF EJPDJBEBHDF, List<RangeMigration> ONECFNEFIKM, CIHLHJIOPKJ NOOPFFLAPPI, CIHLHJIOPKJ LCKDIAGMKMC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x7BFF970", Offset = "0x7BFE370", VA = "0x187BFF970")]
	private float MLDDLDCOGFP(float EDPLBBNMPBO, Vector2 JGOHGDICEDD, Vector2 BBLNJAJKCLI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x7BFE2F0", Offset = "0x7BFCCF0", VA = "0x187BFE2F0")]
	private (RangeMigration?, RangeMigration?) AGPIDLMHNFC(List<RangeMigration> NJBIOFNMHJO, GAKPNEPDBDG ALMHAEABCKC, CIHLHJIOPKJ NOOPFFLAPPI, CIHLHJIOPKJ LCKDIAGMKMC)
	{
		return default((RangeMigration?, RangeMigration?));
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public interface GNAIAFAGFIH
{
	[Cpp2IlInjected.Token(Token = "0x6000028")]
	[Cpp2IlInjected.Address(Slot = "0")]
	bool NBMIIJPGICK(HEFJDHOHCHF EJPDJBEBHDF, IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON);

	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool NBMIIJPGICK(NCOIOOIHPIG BGHBMILPOKK, IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON);
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
		public EDIPBJBNEML AnimationPoseType;

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
		[Cpp2IlInjected.Address(RVA = "0x7BE1380", Offset = "0x7BDFD80", VA = "0x187BE1380")]
		public void KHIAGJKLPPG(AnimationPoseSetting NDNHELJMDCG, float GDOEGNAMAAE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE14B0", Offset = "0x7BDFEB0", VA = "0x187BE14B0")]
		public AnimationPoseSetting()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarFKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE1DA0", Offset = "0x7BE07A0", VA = "0x187BE1DA0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1D60", Offset = "0x7BE0760", VA = "0x187BE1D60")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE14D0", Offset = "0x7BDFED0", VA = "0x187BE14D0")]
		private void HFCCGDEANGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B70AD0", Offset = "0x7B6F4D0", VA = "0x187B70AD0", Slot = "4")]
		public void SetEnabled(bool KALBLPGLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1DD0", Offset = "0x7BE07D0", VA = "0x187BE1DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE1E10", Offset = "0x7BE0810", VA = "0x187BE1E10")]
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
		[Cpp2IlInjected.Address(RVA = "0x7BE1E90", Offset = "0x7BE0890", VA = "0x187BE1E90")]
		public AnimationPoseSetting MMOGJLFBADL(EDIPBJBNEML GNBGFMBAPHM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1E50", Offset = "0x7BE0850", VA = "0x187BE1E50")]
		public void JBAOHJPBOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x7BE1EC0", Offset = "0x7BE08C0", VA = "0x187BE1EC0")]
		public AvatarFullBodyConfiguration()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class AvatarIKEditorPosingHandle : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public enum NEILAJOOHNA
		{
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			Effector,
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			BendTarget
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		[SerializeField]
		[EMFMMKKCPNF(MEAOHOOOBOD.Self, false, false, false)]
		private Transform ikHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		[SerializeField]
		private NEILAJOOHNA handleType;

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
		[Cpp2IlInjected.Address(RVA = "0x7BE29B0", Offset = "0x7BE13B0", VA = "0x187BE29B0")]
		private void OnDrawGizmos()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2970", Offset = "0x7BE1370", VA = "0x187BE2970")]
		private void OnDrawGizmosSelected()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2370", Offset = "0x7BE0D70", VA = "0x187BE2370")]
		private void HFCCGDEANGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x7B70AD0", Offset = "0x7B6F4D0", VA = "0x187B70AD0", Slot = "4")]
		public void SetEnabled(bool KALBLPGLPEO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x7BE29E0", Offset = "0x7BE13E0", VA = "0x187BE29E0")]
		public AvatarIKEditorPosingHandle()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[DisallowMultipleComponent]
	public class AvatarModernBodyBehaviour : MonoBehaviour, AADODDPPDOK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		[Header("Configuration")]
		[SerializeField]
		private DOOHILAACHK avatarBodyType;

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
		[EMFMMKKCPNF(MEAOHOOOBOD.SelfAndChildren, false, false, false)]
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
		private IEDKGAPNBPK GEJGIGBMABD;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public IEDKGAPNBPK CENNDJCHNME
		{
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xB25750", Offset = "0xB24150", VA = "0x180B25750", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public Transform NNFKNGBGKPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0x7BE3880", Offset = "0x7BE2280", VA = "0x187BE3880", Slot = "10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2A10", Offset = "0x7BE1410", VA = "0x187BE2A10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3740", Offset = "0x7BE2140", VA = "0x187BE3740")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7BE36F0", Offset = "0x7BE20F0", VA = "0x187BE36F0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3680", Offset = "0x7BE2080", VA = "0x187BE3680")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2A10", Offset = "0x7BE1410", VA = "0x187BE2A10", Slot = "5")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2E50", Offset = "0x7BE1850", VA = "0x187BE2E50", Slot = "6")]
		public IEDKGAPNBPK CreateAvatarSystem(string BFBDOGNGGDI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3680", Offset = "0x7BE2080", VA = "0x187BE3680", Slot = "7")]
		public void TeardownAvatarSystem()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x7BE2AD0", Offset = "0x7BE14D0", VA = "0x187BE2AD0", Slot = "8")]
		public bool CleanupDisplayMeshes()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x7BE3790", Offset = "0x7BE2190", VA = "0x187BE3790", Slot = "9")]
		public void UpdatePostIKAnimControllers(float HMAHKNFCDDP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public AvatarModernBodyBehaviour()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
internal class CKLMNNBMHKN : IEDKGAPNBPK
{
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	internal class FPHMCANKMGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		private Vector3 JKPCJFMOCJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		private Quaternion JEGKHKAFICM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		private Vector3 BNHJEENMPCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private Transform MHCJFKHMNJA;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector3 ONGBDDADIOM
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x206E010", Offset = "0x206CA10", VA = "0x18206E010")]
			[CompilerGenerated]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x206E030", Offset = "0x206CA30", VA = "0x18206E030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Quaternion PFEFONJJHFA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x1125A90", Offset = "0x1124490", VA = "0x181125A90")]
			[CompilerGenerated]
			get
			{
				return default(Quaternion);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1124B70", Offset = "0x1123570", VA = "0x181124B70")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public float KOCLOHLINPL
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x113F030", Offset = "0x113DA30", VA = "0x18113F030")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x18AFA80", Offset = "0x18AE480", VA = "0x1818AFA80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public bool CDMEFNNIAKA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA17C20", Offset = "0xA16620", VA = "0x180A17C20")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0xA17BD0", Offset = "0xA165D0", VA = "0x180A17BD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool COEJLGDCPKG
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xA17A50", Offset = "0xA16450", VA = "0x180A17A50")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xA17BB0", Offset = "0xA165B0", VA = "0x180A17BB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public bool DIEOLKOGNPO
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA17C30", Offset = "0xA16630", VA = "0x180A17C30")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xA17A60", Offset = "0xA16460", VA = "0x180A17A60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float ENHDMCGMEOK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0xD17B40", Offset = "0xD16540", VA = "0x180D17B40")]
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xD17A40", Offset = "0xD16440", VA = "0x180D17A40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x7C05890", Offset = "0x7C04290", VA = "0x187C05890")]
		public void ODKOIKJPMIE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7C04C50", Offset = "0x7C03650", VA = "0x187C04C50")]
		public void CNEJJLLLEMF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x7C04D80", Offset = "0x7C03780", VA = "0x187C04D80")]
		public float IKMJBAIBGFK(Vector3 MLGDDJKPFKJ, Quaternion MGDDBLADCMG, [In] AvatarFootSettings NFHDIBECGNG, float PNHOJGBDLFK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x7C04F90", Offset = "0x7C03990", VA = "0x187C04F90")]
		public void KODNFODCBCC(Vector3 NECHIJCFABL, Quaternion PLAPEDBKGLD, Transform IMKKEJJHOCI, float ANKDIFDBGJI, bool NKLDEGMNDNB, bool DKMALLHBEMJ, float JICMAGIACDF, float HGOIPJHAFAH, Transform ALPBGLGCPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x7C05660", Offset = "0x7C04060", VA = "0x187C05660")]
		public void OCHHOBEEPLH(Transform ODIFNGFJDME, Transform ALPBGLGCPNB, bool HIKDDKKFIBM, bool PPHFMMHCIAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x7C04C60", Offset = "0x7C03660", VA = "0x187C04C60")]
		private void EEPDEFDOPKG(Transform ALPBGLGCPNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x7C04B00", Offset = "0x7C03500", VA = "0x187C04B00")]
		public bool CIOENONBGJO(Transform ALPBGLGCPNB, AvatarFullBodyConfiguration DHADAJLMNNE, Vector3 MDDNBBHKBMO, float FIKEEMFADLG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x7C04D60", Offset = "0x7C03760", VA = "0x187C04D60")]
		public void GGFEGGPJHAA(float HGOIPJHAFAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x7C058A0", Offset = "0x7C042A0", VA = "0x187C058A0")]
		public FPHMCANKMGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000015")]
	private class MJAJKJMALBJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private float HMGALGAKJBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private bool KNNFMIJPPFC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public AnimationPoseSetting CMEFPMDFCGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		private float CNBHPBLJGID;

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C0F0", Offset = "0x7C0AAF0", VA = "0x187C0C0F0")]
		public void BKCPEGNMABA(IKSolverVR.Arm JMBAOCBNKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C260", Offset = "0x7C0AC60", VA = "0x187C0C260")]
		public void FKNEMJCKEGE(IKSolverVR.Arm JMBAOCBNKDM, float JALKPCGGHOK, bool KNNFMIJPPFC, AvatarFullBodyConfiguration DHADAJLMNNE, float HAFMFFEGLKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D110", Offset = "0x7C0BB10", VA = "0x187C0D110")]
		private void PAHCFJMEELN(IKSolverVR.Arm JMBAOCBNKDM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CBD0", Offset = "0x7C0B5D0", VA = "0x187C0CBD0")]
		public void KLOPJEHDAMN(IKSolverVR.Arm JMBAOCBNKDM, Transform DMOCPBNBJCH, Transform IMKKEJJHOCI, Quaternion AEMANMIIEHE, Vector3 NJEDJAKLIAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C740", Offset = "0x7C0B140", VA = "0x187C0C740")]
		private (Vector3, Quaternion) HAGCNGHALNK(NJGIIBLFCND KBKIMBCMOKO, Quaternion AINMGOLNKCF, Vector3 LHGNOEJLPGJ)
		{
			return default((Vector3, Quaternion));
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7C0CFB0", Offset = "0x7C0B9B0", VA = "0x187C0CFB0")]
		public void LFFCABLKHKJ(NJGIIBLFCND KBKIMBCMOKO, IKSolverVR.Arm JMBAOCBNKDM, Quaternion AINMGOLNKCF, Vector3 LHGNOEJLPGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7C0BAF0", Offset = "0x7C0A4F0", VA = "0x187C0BAF0")]
		public void ALCFKPGMBDK(NJGIIBLFCND KBKIMBCMOKO, IKSolverVR.Arm JMBAOCBNKDM, Quaternion AINMGOLNKCF, Vector3 LHGNOEJLPGJ, [In] AvatarFullBodyConfiguration DHADAJLMNNE, [In] DGDDFFAGDNA LOPOEJHIPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C120", Offset = "0x7C0AB20", VA = "0x187C0C120")]
		public void FGOICOOIIJG(EDIPBJBNEML GIBCCAHPLFO, AvatarFullBodyConfiguration DHADAJLMNNE, DGDDFFAGDNA LOPOEJHIPKN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7C0C2A0", Offset = "0x7C0ACA0", VA = "0x187C0C2A0")]
		public void GANNNJJDJNC(IKSolverVR.Arm JMBAOCBNKDM, Transform DMOCPBNBJCH, Vector3 ABIBCHFEEHG, float GMFADLDKPMJ, Quaternion DLEEHIIALLD, Vector3 HIHBMEPHFIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D150", Offset = "0x7C0BB50", VA = "0x187C0D150")]
		public MJAJKJMALBJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000016")]
	private enum LLKJGODOPPA
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
	private struct OIKOCHIAFKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public float strideScale;
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	[CompilerGenerated]
	private struct NCDHBHEFGFA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public Transform pelvis;
	}

	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private static readonly int LFMHLODCNJA;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int OPJEIDBODGK;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int KKPHOGMFIBA;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int EKGBLFBPCEH;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int DODMPNOBGLI;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int OBLAJNGMDHO;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int PNBOADGOJJC;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int HHDLPHNCMPJ;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int DADFNDJAAKA;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int JBPFFJEBNGB;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int LCFAKDABCCH;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int INOBNNIKIOE;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int NGEECFDCGAH;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int AILLFKDDFFB;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int IAGEJGFMPBO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly int HEFOILBFAFO;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly int GOPJBJFHKBI;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static readonly int NBIDMAIAOHL;

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly int NMDLLLOIAFE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly int PNOMPNLLFBA;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static readonly int NDFBGODBOIH;

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static readonly int HDPJAHICHPL;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly int NFGCJNMPCLC;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly int DNCEGKMEOLH;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly int DKFJGHLELFO;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly int KCKNNPMNPFP;

	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private static readonly int IDIKNJOJNNH;

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private static readonly int DLINLDOAIPL;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly int DHMCMJIDHLI;

	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	private static readonly int EIMBJBPIGLB;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static readonly int HOPFKIEGEMO;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly int FHEDKJIIAJH;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly Vector3 JKOMPCAHOCP;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly int AENBBGMGOEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private bool IEDFFKFFDPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private bool GGMIJBJFKJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private bool DBCNJADCKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private bool PKGGJIHABNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private bool JFBNDCAHIEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	private bool BLDKBLMGEMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private Vector3 BJJIOLCIAGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private string BCMMPFHHFBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private JGBLHDDLMKB? BONHBLGJEGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private AEKKJHEAJHH? APANPCDPGMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private IEMPAIAEGKL JBJCMHMICML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private IHIKIEEIPMG GIOBKFPCKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private NJGIIBLFCND OADIJEGHPBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private NJGIIBLFCND JBPHMNAFEKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private bool PKNDDCPABNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x269")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private bool FOKBDFBBPGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly KFGFFNJAFPB IKIELBGJMEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly AKGKOLEFPMC JGOBDMFEKBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private int IBHLCOIJAMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private float EJEHLOCBBPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private GameObject OMFFBHHFCLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x290")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private Transform AAMAHBFHNEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x298")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Transform FIBEOANMHHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private Transform BGHHLOFGJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2A8")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	private Transform NDFDFLPPBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private float FAHJIHMBGIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B4")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	private float JKCHHLEBEOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2B8")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	private Vector3 HLOOGNHIDEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C4")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Quaternion OGJBLKENPHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2D8")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private Transform FKBKNJBGNFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private Transform BAFOFOICEGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2E8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private Transform NCDMDEPPDKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private HBPGNCABKBF KECBBAGNPEH;

	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private static readonly ProfilerMarker COJDMDGNELB;

	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private static readonly ProfilerMarker BPFKCGOJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2F8")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private ProfilerMarker EOAPPJJCLBB;

	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private static readonly ProfilerMarker NODBJGBLHKP;

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private static readonly ProfilerMarker ADKDLHJMICD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static readonly ProfilerMarker MDHBBHPGFAC;

	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private static readonly List<CKLMNNBMHKN> DKIGKDCIEJE;

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private static int COCLEHKNLAM;

	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private static readonly Lazy<IRecRoomQualityConfigProvider> HDGLEIKADDB;

	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private static int DLKEALLCDEM;

	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private static int EBNKMJKODKK;

	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private static int LANGCJOILOH;

	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private static int IEJAHGEIAHA;

	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private static float OCGDCLJNGCE;

	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private static int LMNDDOPDILA;

	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private static float IACDKBMCPIH;

	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private static float CIKAHJLEDCC;

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private static float LIFMJKCKDAA;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static float DKFNNKOGHPI;

	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private static MBJEKBPPKJG JEGDMBIEOKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x300")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private float PMNMIGCDHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x304")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private bool EGJLLEOEFCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x308")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private float AKGAPJHFBCO;

	[Cpp2IlInjected.Token(Token = "0x4000117")]
	private static readonly int ECKHCOHGDOP;

	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private static readonly int IDFDHLBINAF;

	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private static readonly int CPHNCAEJMIO;

	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private static readonly int HILEIFKNFHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x310")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private FPHMCANKMGG BLKAGPOANOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x318")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private FPHMCANKMGG NBMAGAOFKLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x320")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private float JMLEEONFJEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x324")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private Vector3 FGOBDNAFECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x330")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	private Vector3 CBOJOCHJCKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x33C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private bool EALACCPKHIF;

	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private static readonly Quaternion DFLEKIGBLDM;

	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private static readonly Quaternion IPMGALKCFDM;

	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private static readonly Vector3 BILFMDDENHH;

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private static readonly Vector3 CONPCGNHHPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x348")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private float OAOFCHPHLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34C")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private float BICOIHLDBLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x350")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private MJAJKJMALBJ LIEDEIDIJNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x358")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private MJAJKJMALBJ CMOLJBDJHIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x360")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private OLCLPCNEOOJ AIMMNBMEGMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x368")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private GMOONBEHAMM GOMPDIBHOHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x370")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly NMBOFKOMDPE PMJBBDAIFLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x378")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private float KIOKAKBPCIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x37C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private float HLNMDMPENEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x380")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private readonly GMOONBEHAMM OKCILPKBICD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x388")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private Vector3 HHDBDLLGHDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x394")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private Vector3 HKDNBKOHIKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A0")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private float NCPDOBGOEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A4")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private float CNAHHIHJIOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3A8")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private readonly GMOONBEHAMM OKBCLNOELLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B0")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private readonly OLCLPCNEOOJ GGEKJNJCLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3B8")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private readonly GMOONBEHAMM HECOIOOKEMN;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public CNBOOGKDGFE CBBHCJJEFAG
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public CNBOOGKDGFE IFPEEGPOABP
	{
		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "11")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public AvatarConfiguration LNJLLPAJDHO
	{
		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7A20", Offset = "0x7BE6420", VA = "0x187BE7A20", Slot = "23")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public DOOHILAACHK LBOIOJACFIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x7BF1110", Offset = "0x7BEFB10", VA = "0x187BF1110", Slot = "24")]
		get
		{
			return default(DOOHILAACHK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public AvatarFullBodyConfiguration FNOHIDLEGFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA710", Offset = "0x7BF9110", VA = "0x187BFA710")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	private Transform BFJGPLCGLHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF360", Offset = "0x7BEDD60", VA = "0x187BEF360")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	private Transform MHGAGCGGDLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB7E0", Offset = "0x7BFA1E0", VA = "0x187BFB7E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	private SkinnedMeshRenderer JHLKBBLKBII
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x7BF57A0", Offset = "0x7BF41A0", VA = "0x187BF57A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	private Renderer[] PDCLGMGHMMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x7BE38A0", Offset = "0x7BE22A0", VA = "0x187BE38A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	private GameObject[] NCJLNOLCOML
	{
		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7920", Offset = "0x7BE6320", VA = "0x187BE7920")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	private Animator CMAEPHGNKCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x7BFA150", Offset = "0x7BF8B50", VA = "0x187BFA150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	private VRIK BBBMMLBLOEA
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x7BF58A0", Offset = "0x7BF42A0", VA = "0x187BF58A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	private EKMGOOCJEJL EFGFCJDJKEE
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF30F0", Offset = "0x7BF1AF0", VA = "0x187BF30F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	private EKMGOOCJEJL CLCFCLCHCDE
	{
		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x7BEB530", Offset = "0x7BE9F30", VA = "0x187BEB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	private EKMGOOCJEJL JJHOBIHFFBC
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFC370", Offset = "0x7BFAD70", VA = "0x187BFC370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	private EKMGOOCJEJL JADINKHNFMK
	{
		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x7BE73D0", Offset = "0x7BE5DD0", VA = "0x187BE73D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private EKMGOOCJEJL MFCEKBDPOND
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x7BE6500", Offset = "0x7BE4F00", VA = "0x187BE6500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private EKMGOOCJEJL DLIJPEDBIOL
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5FD0", Offset = "0x7BF49D0", VA = "0x187BF5FD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private EKMGOOCJEJL BNDGEICEPAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2060", Offset = "0x7BF0A60", VA = "0x187BF2060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	private EKMGOOCJEJL IDEIFGDHLKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x7BF2E90", Offset = "0x7BF1890", VA = "0x187BF2E90")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public AEKKJHEAJHH CHKIIPPKCFP
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x7BE81C0", Offset = "0x7BE6BC0", VA = "0x187BE81C0", Slot = "16")]
		get
		{
			return default(AEKKJHEAJHH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public LPODLLODNDM HAFHNEJIAMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xAD38F0", Offset = "0xAD22F0", VA = "0x180AD38F0", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public HBPKIIMPBKO MDPFEGBEMBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xAD38E0", Offset = "0xAD22E0", VA = "0x180AD38E0", Slot = "18")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public JPJMMHEAOFC HKEPIPBLCGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xB49660", Offset = "0xB48060", VA = "0x180B49660", Slot = "19")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public JPJMMHEAOFC LGBOIAIIFND
	{
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0xAD3B80", Offset = "0xAD2580", VA = "0x180AD3B80", Slot = "20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public string NJPCGFPFKMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xA0A590", Offset = "0xA08F90", VA = "0x180A0A590", Slot = "21")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	private Transform EPDFMMONMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7EC0", Offset = "0x7BE68C0", VA = "0x187BE7EC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	private Transform NDFEEAMEIFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5C80", Offset = "0x7BF4680", VA = "0x187BF5C80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	private Transform KGHJAOIOGJI
	{
		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB0F0", Offset = "0x7BF9AF0", VA = "0x187BFB0F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	private Transform NBONFOGOLMK
	{
		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9490", Offset = "0x7BF7E90", VA = "0x187BF9490")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	private Transform NJCMIIOPCFL
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x7BFB120", Offset = "0x7BF9B20", VA = "0x187BFB120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	private bool KJKIOENBHOO
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0060", Offset = "0x7BEEA60", VA = "0x187BF0060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool JFLDGFHAEAB
	{
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0060", Offset = "0x7BEEA60", VA = "0x187BF0060")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private bool PCJKBCPOFEF
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF3D30", Offset = "0x7BF2730", VA = "0x187BF3D30")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	private Transform EPHCPOEJBMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x7BF31F0", Offset = "0x7BF1BF0", VA = "0x187BF31F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public GameObject HNGFDIJGINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7BF93F0", Offset = "0x7BF7DF0", VA = "0x187BF93F0", Slot = "22")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public HeadLogicOffsets NIDCKNBNEFH
	{
		[Cpp2IlInjected.Token(Token = "0x600008B")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5C80", Offset = "0x7BE4680", VA = "0x187BE5C80", Slot = "33")]
		get
		{
			return default(HeadLogicOffsets);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Transform BKLDBEEIKCF
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0xB49FF0", Offset = "0xB489F0", VA = "0x180B49FF0", Slot = "34")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public Transform LPPFJHCHFMP
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0xB49560", Offset = "0xB47F60", VA = "0x180B49560", Slot = "35")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform FNPLKFHACGN
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0xB318E0", Offset = "0xB302E0", VA = "0x180B318E0", Slot = "36")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Transform FHBMKPHBJHG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0xB49F90", Offset = "0xB48990", VA = "0x180B49F90", Slot = "37")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public Vector3 LCPKOOFMFJH
	{
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5D00", Offset = "0x7BE4700", VA = "0x187BE5D00", Slot = "38")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	public float EDIPOOODKKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x7BE5770", Offset = "0x7BE4170", VA = "0x187BE5770", Slot = "39")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public Transform DMONDKMHHFF
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x7BE57C0", Offset = "0x7BE41C0", VA = "0x187BE57C0", Slot = "40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Transform IFLKGNHOBIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x1497D90", Offset = "0x1496790", VA = "0x181497D90", Slot = "42")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Transform DMNCJNAOAFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x1497B50", Offset = "0x1496550", VA = "0x181497B50", Slot = "43")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public Transform EHGIAOIFICH
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0xAD3B00", Offset = "0xAD2500", VA = "0x180AD3B00", Slot = "44")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	private bool HGPDPHAEOPG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x7BEC020", Offset = "0x7BEAA20", VA = "0x187BEC020")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public NBHKBEPCJOC<IEDKGAPNBPK.EBJFIELNBDB> EALFAMAMPND
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7BE7B20", Offset = "0x7BE6520", VA = "0x187BE7B20", Slot = "45")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	private bool KMNBHJFFOFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0340", Offset = "0x7BEED40", VA = "0x187BF0340")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000035")]
	private bool PJGECHLMKEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7BEF460", Offset = "0x7BEDE60", VA = "0x187BEF460")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7E90", Offset = "0x7BF6890", VA = "0x187BF7E90")]
	private float LEBKODDKKJL(JCAHGOLPIOM MMCFJCLCPGF, float COPJKKNOBAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x7BECB60", Offset = "0x7BEB560", VA = "0x187BECB60")]
	private void EDEPMIEACMG([In] DGDDFFAGDNA GLHNJLKPLNE, [In] AvatarFullBodyConfiguration DHADAJLMNNE, bool BOMCLKNAAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB420", Offset = "0x7BF9E20", VA = "0x187BFB420")]
	private float OOFBIDNNKPA([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x7BE78A0", Offset = "0x7BE62A0", VA = "0x187BE78A0")]
	private float CGLCCONAADI([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC110", Offset = "0x7BEAB10", VA = "0x187BEC110")]
	private void DJBCCLAHBHH(DGDDFFAGDNA GLHNJLKPLNE, AvatarFullBodyConfiguration DHADAJLMNNE, bool BOMCLKNAAIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8FC0", Offset = "0x7BF79C0", VA = "0x187BF8FC0")]
	private void NCCJIJKLIDF([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2830", Offset = "0x7BF1230", VA = "0x187BF2830")]
	private void HHGBNPNKLKD([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x7BFDBC0", Offset = "0x7BFC5C0", VA = "0x187BFDBC0")]
	public CKLMNNBMHKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BE82D0", Offset = "0x7BE6CD0", VA = "0x187BE82D0", Slot = "13")]
	public void CNMIAIOJBCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BF77F0", Offset = "0x7BF61F0", VA = "0x187BF77F0", Slot = "14")]
	public void LALIFFGCHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB350", Offset = "0x7BF9D50", VA = "0x187BFB350", Slot = "15")]
	public void OOCJKALFEBK(bool DPAPNFGJDNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8BE0", Offset = "0x7BF75E0", VA = "0x187BF8BE0", Slot = "26")]
	public Transform MIMGFHFMNGN(string FEGPDLNJFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5D90", Offset = "0x7BE4790", VA = "0x187BE5D90", Slot = "27")]
	public Vector3? BFFMEBBJAOJ(string FEGPDLNJFDD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7F10", Offset = "0x7BE6910", VA = "0x187BE7F10", Slot = "7")]
	public void CMIGAMAKMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6A70", Offset = "0x7BF5470", VA = "0x187BF6A70")]
	private void KOGEFENCNLC(AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x7BE62C0", Offset = "0x7BE4CC0", VA = "0x187BE62C0", Slot = "8")]
	public void BNGABKLMENB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5B80", Offset = "0x7BE4580", VA = "0x187BE5B80")]
	private void BCCKEJKCJAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4320", Offset = "0x7BF2D20", VA = "0x187BF4320")]
	private Vector3 JHENMFJMLCJ([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6870", Offset = "0x7BF5270", VA = "0x187BF6870", Slot = "6")]
	public void KNGPHDPHMAK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF32F0", Offset = "0x7BF1CF0", VA = "0x187BF32F0")]
	private void ILAOABPKBEF(bool BOMCLKNAAIJ, LLKJGODOPPA JPAFOPHBNCO, AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6250", Offset = "0x7BE4C50", VA = "0x187BE6250", Slot = "9")]
	public void BNEMAHIDAPE(float PFAEDBFFDKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF10C0", Offset = "0x7BEFAC0", VA = "0x187BF10C0")]
	private void GAONCKCJLED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x7BE8820", Offset = "0x7BE7220", VA = "0x187BE8820", Slot = "4")]
	public void COEPBIHHEEE(string BFBDOGNGGDI, JGBLHDDLMKB AAOHBCCECKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCCC0", Offset = "0x7BFB6C0", VA = "0x187BFCCC0", Slot = "5")]
	public void PNHHFBEPJEE(AEKKJHEAJHH PFEAEAELGJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5E70", Offset = "0x7BF4870", VA = "0x187BF5E70", Slot = "12")]
	public void KGKFGANIDOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7B30", Offset = "0x7BE6530", VA = "0x187BE7B30", Slot = "25")]
	public void CKLHKDECDKF([Out] Vector3 MLOOIHNNBNE, [Out] Quaternion DLEEHIIALLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6A50", Offset = "0x7BE5450", VA = "0x187BE6A50")]
	private void BPNCOHMOHEM([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2F90", Offset = "0x7BF1990", VA = "0x187BF2F90", Slot = "28")]
	public void HPLCFAFFOAE(float HFKGABGFECI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEE80", Offset = "0x7BED880", VA = "0x187BEEE80", Slot = "29")]
	public void ENFPGMOBANL(float CDHKMADDALN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5F20", Offset = "0x7BE4920", VA = "0x187BE5F20", Slot = "46")]
	public void BGMJNEFABHG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5F70", Offset = "0x7BE4970", VA = "0x187BE5F70", Slot = "30")]
	public void BMDPFEAPFDF(bool GLNEOOCFJLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7BE7380", Offset = "0x7BE5D80", VA = "0x187BE7380", Slot = "31")]
	public HandLogicOffsets CBJDIKJBJLA()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAC20", Offset = "0x7BE9620", VA = "0x187BEAC20", Slot = "32")]
	public PlatformSpecificPlayerHandOffsets DBIJJCANDFA()
	{
		return default(PlatformSpecificPlayerHandOffsets);
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5740", Offset = "0x7BE4140", VA = "0x187BE5740")]
	private void AFALDGNNBLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4C60", Offset = "0x7BF3660", VA = "0x187BF4C60")]
	private void JKPPKMLLHJL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6F40", Offset = "0x7BE5940", VA = "0x187BE6F40")]
	private void CBFDLEPEBMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x7BF59A0", Offset = "0x7BF43A0", VA = "0x187BF59A0")]
	private void KAJPKMGNBEC(LEOFMIOLMNC BFCMNAFEMIP, bool MPNHLGBIEGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x7BEAA50", Offset = "0x7BE9450", VA = "0x187BEAA50")]
	private void CPONPIBIAEF(LEOFMIOLMNC BFCMNAFEMIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x7BEABD0", Offset = "0x7BE95D0", VA = "0x187BEABD0")]
	public Vector3 DAFNIOCJKFK()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7BA0", Offset = "0x7BF65A0", VA = "0x187BF7BA0")]
	private void LDHGLCOMAOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2810", Offset = "0x7BF1210", VA = "0x187BF2810")]
	private void HGEBJPEHNPK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2160", Offset = "0x7BF0B60", VA = "0x187BF2160")]
	private void HFOAHMCFBCM(DGDDFFAGDNA GLHNJLKPLNE, AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7640", Offset = "0x7BF6040", VA = "0x187BF7640")]
	private float LAEAEPJGNGO([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3C50", Offset = "0x7BF2650", VA = "0x187BF3C50")]
	private int INKHHNALNBC([In] DADFPPOCBHH OGKNKFALNIN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x7BEE640", Offset = "0x7BED040", VA = "0x187BEE640")]
	private void EHGFGKAFEFF(DGDDFFAGDNA GLHNJLKPLNE, bool HBHPFIPBFHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7EB0", Offset = "0x7BF68B0", VA = "0x187BF7EB0")]
	private static void LGELPIHAPCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF03C0", Offset = "0x7BEEDC0", VA = "0x187BF03C0")]
	private static void GAKGOMMGHBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2C20", Offset = "0x7BF1620", VA = "0x187BF2C20")]
	private float HMKAFGJHEHO()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB500", Offset = "0x7BE9F00", VA = "0x187BEB500")]
	private static int DHIPJCIFCBI(CKLMNNBMHKN OCPABDEGAMF, CKLMNNBMHKN MAMEIEKFKPM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x7BE55F0", Offset = "0x7BE3FF0", VA = "0x187BE55F0", Slot = "41")]
	public DGDDFFAGDNA AEFOGGIHLKE()
	{
		return default(DGDDFFAGDNA);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2DF0", Offset = "0x7BF17F0", VA = "0x187BF2DF0")]
	private bool HNLPFEJPPEF(int KHNIMGKFPOO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2FA0", Offset = "0x7BF19A0", VA = "0x187BF2FA0")]
	public void IBGPBKJMBPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4DE0", Offset = "0x7BF37E0", VA = "0x187BF4DE0")]
	private (bool, bool) JLECOOMDAEH()
	{
		return default((bool, bool));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC190", Offset = "0x7BFAB90", VA = "0x187BFC190")]
	private (float, float) PFCLJOGBCEM([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x7BE39A0", Offset = "0x7BE23A0", VA = "0x187BE39A0")]
	private void ADHCHHFBMHM([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x7BEEB60", Offset = "0x7BED560", VA = "0x187BEEB60")]
	private void EKEBJPPBJIO([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x7BF87C0", Offset = "0x7BF71C0", VA = "0x187BF87C0")]
	private void MEKGAOENFIO([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE, AvatarFootSettings NFHDIBECGNG, bool LOMGKMPNFMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3BD0", Offset = "0x7BF25D0", VA = "0x187BF3BD0")]
	private float INCENKJIPFE()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF4E0", Offset = "0x7BEDEE0", VA = "0x187BEF4E0")]
	private void FFNBHBDIBHL(DGDDFFAGDNA LOPOEJHIPKN, AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8D30", Offset = "0x7BF7730", VA = "0x187BF8D30")]
	private float MJBBICNBOAM()
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6A80", Offset = "0x7BE5480", VA = "0x187BE6A80")]
	private void BPPENJGIPOM([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6590", Offset = "0x7BF4F90", VA = "0x187BF6590")]
	private void KLOPJEHDAMN([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3F30", Offset = "0x7BF2930", VA = "0x187BF3F30")]
	private void JDJDKMIFPBA([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B8")]
	[Cpp2IlInjected.Address(RVA = "0x7BF00B0", Offset = "0x7BEEAB0", VA = "0x187BF00B0")]
	private void FJFKNPIDOMD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x7BE74D0", Offset = "0x7BE5ED0", VA = "0x187BE74D0")]
	private void CENCAGGFMPL(float BFCCHNIIJEG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x7BEF1D0", Offset = "0x7BEDBD0", VA = "0x187BEF1D0")]
	private void EOIIFPKHPNN([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5FC0", Offset = "0x7BE49C0", VA = "0x187BE5FC0")]
	private void BMGJLAKFBEA(NJGIIBLFCND KHAEHOKJEIJ, IKSolverVR.Arm JMBAOCBNKDM, Transform ADBPJODINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x7BF60D0", Offset = "0x7BF4AD0", VA = "0x187BF60D0")]
	private void KLEJILKGJOB(DGDDFFAGDNA LOPOEJHIPKN, AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC990", Offset = "0x7BEB390", VA = "0x187BEC990")]
	private void DMNMIKKMKGJ(DMMFFJGDBPA LFDKDIOINCI, JPJMMHEAOFC KHAEHOKJEIJ, IKSolverVR.Arm JMBAOCBNKDM, float JALKPCGGHOK, float OPODNMDMBBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5820", Offset = "0x7BE4220", VA = "0x187BE5820")]
	private void AOFENKIOLOF([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x7BFC470", Offset = "0x7BFAE70", VA = "0x187BFC470")]
	private void PGOJGKICIIE([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8400", Offset = "0x7BF6E00", VA = "0x187BF8400")]
	protected void LPDAHPMOAHF([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x7BF80B0", Offset = "0x7BF6AB0", VA = "0x187BF80B0")]
	private void LKKBGOGKBCJ([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x7BFCA70", Offset = "0x7BFB470", VA = "0x187BFCA70")]
	protected void PKFCECHJIEM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x7BEACE0", Offset = "0x7BE96E0", VA = "0x187BEACE0")]
	private void DDPEENGHCKF([In] DGDDFFAGDNA LOPOEJHIPKN, [In] LLKJGODOPPA JPAFOPHBNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5CC0", Offset = "0x7BF46C0", VA = "0x187BF5CC0")]
	private void KELLEIIALID(DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7BF93B0", Offset = "0x7BF7DB0", VA = "0x187BF93B0")]
	private void NDIIHGFNHLC([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA7A0", Offset = "0x7BF91A0", VA = "0x187BFA7A0")]
	private Vector3 OIEIJBHHEEI([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3020", Offset = "0x7BF1A20", VA = "0x187BF3020")]
	private void IDIMBPDDAFH([In] DGDDFFAGDNA LOPOEJHIPKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x7BE6600", Offset = "0x7BE5000", VA = "0x187BE6600")]
	private float BOEACNHOHBP(float HGOIPJHAFAH, [In] DGDDFFAGDNA LOPOEJHIPKN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x7BE5A30", Offset = "0x7BE4430", VA = "0x187BE5A30")]
	private void BBBGDCCCLMN(float HGOIPJHAFAH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x7BEC2A0", Offset = "0x7BEACA0", VA = "0x187BEC2A0")]
	private void DMDIIBEEHOP([In] DGDDFFAGDNA LOPOEJHIPKN, LLKJGODOPPA JPAFOPHBNCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB990", Offset = "0x7BFA390", VA = "0x187BFB990")]
	private float PEDNJBKAPKD([In] DGDDFFAGDNA GLHNJLKPLNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4FB0", Offset = "0x7BF39B0", VA = "0x187BF4FB0")]
	private void JMPCFDNFCJD(DGDDFFAGDNA LOPOEJHIPKN, LLKJGODOPPA JPAFOPHBNCO, Vector3 OGHAOCPCLMC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BFACB0", Offset = "0x7BF96B0", VA = "0x187BFACB0")]
	private static void OJFEOOHOGNB(Transform MNINMACDPEC, Quaternion NGPACIMGGNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB4B0", Offset = "0x7BF9EB0", VA = "0x187BFB4B0")]
	private void PAKLCPDGFAE([In] DGDDFFAGDNA BKHIANMHGMM, [In] DADFPPOCBHH OGKNKFALNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x7BF98A0", Offset = "0x7BF82A0", VA = "0x187BF98A0")]
	private void NKGDPPODOAJ([In] DGDDFFAGDNA BKHIANMHGMM, [In] DADFPPOCBHH OGKNKFALNIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB160", Offset = "0x7BF9B60", VA = "0x187BFB160")]
	private void OMFJGFIFLFE(float AMBLDLHLLDC, [In] DGDDFFAGDNA GLHNJLKPLNE, float CNMIGKDDPHD = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x7BF44A0", Offset = "0x7BF2EA0", VA = "0x187BF44A0")]
	private float JKEPCGHNCOK([In] DGDDFFAGDNA GLHNJLKPLNE, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7BF2930", Offset = "0x7BF1330", VA = "0x187BF2930")]
	private void HJOGOILKPHG([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1210", Offset = "0x7BEFC10", VA = "0x187BF1210")]
	private void GGJLOKNKNCI([In] DGDDFFAGDNA GLHNJLKPLNE, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x7BF94D0", Offset = "0x7BF7ED0", VA = "0x187BF94D0")]
	private void NGODLDEPJCJ([In] DGDDFFAGDNA GLHNJLKPLNE, float BPHOAIBBAOJ, float EJKANOLCPDM, Vector3 HHGFCEABNBH, float CNMIGKDDPHD = 0.6f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x7BEB630", Offset = "0x7BEA030", VA = "0x187BEB630")]
	private void DIDGNJKKMPE(DGDDFFAGDNA GLHNJLKPLNE, AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAE60", Offset = "0x7BF9860", VA = "0x187BFAE60")]
	private void OJOKLIHCAFK(DGDDFFAGDNA LOPOEJHIPKN, AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BFA250", Offset = "0x7BF8C50", VA = "0x187BFA250")]
	private void OCJAPONPODO(DGDDFFAGDNA GLHNJLKPLNE, AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7120", Offset = "0x7BF5B20", VA = "0x187BF7120")]
	public void KPNILMDFDNC([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BF72E0", Offset = "0x7BF5CE0", VA = "0x187BF72E0")]
	public void KPOPGEAACBB([In] DGDDFFAGDNA LOPOEJHIPKN, [In] AvatarFullBodyConfiguration DHADAJLMNNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8E20", Offset = "0x7BF7820", VA = "0x187BF8E20")]
	[CompilerGenerated]
	internal static void NABHFPGICNO(Transform AJHCLHGHINB, IKSolverVR.Arm JMBAOCBNKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(RVA = "0x7BFB8E0", Offset = "0x7BFA2E0", VA = "0x187BFB8E0")]
	[CompilerGenerated]
	internal static void PDCEGDNKNPC(Vector3 FBJAFIODDCF, Vector3 IHGFPEEKNMH, OIKOCHIAFKK P_2, NCDHBHEFGFA P_3)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8D80", Offset = "0x7BF7780", VA = "0x187BF8D80")]
	[CompilerGenerated]
	internal static void MMCLPAEKHHG(FPHMCANKMGG POAADKNFBOP, FPHMCANKMGG DAEKKHFKMMJ, Vector3 GLNGGCBCNJK, float OLIGKIPGKGK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x7BF3E20", Offset = "0x7BF2820", VA = "0x187BF3E20")]
	[CompilerGenerated]
	internal static bool JAIDBLIEKKG(IKSolverVR.Arm JMBAOCBNKDM, EAIMGANKNLD KPMKNCPNCKG, float GPHOIDJACLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x7BF1C20", Offset = "0x7BF0620", VA = "0x187BF1C20")]
	[CompilerGenerated]
	internal static float GNGELLICOGI(Vector3 HAIPJHPKGNN, Vector3 HGGMLCKOHHI, Vector3 BJMNHFEPAKE, DGDDFFAGDNA GLHNJLKPLNE, AvatarFullBodyConfiguration DHADAJLMNNE, float BACDJHJBLPL)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[RecRoom.NoEngine.Common.Preserve]
internal class BILGIOGGOKC : DBLLJLNNKHO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	private Dictionary<string, IEDKGAPNBPK> NFHPJBDLHFO;

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x7C039E0", Offset = "0x7C023E0", VA = "0x187C039E0")]
	[CGLGNCLDKHN.CKJOAALDIOP]
	internal static void MNLJEBEOCDM(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x7C037C0", Offset = "0x7C021C0", VA = "0x187C037C0", Slot = "4")]
	public IEDKGAPNBPK JIBHDFAMFNJ(string LNOMCAKIKIK, AvatarSystemConfiguration EMKNIPJCMAH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x7C035E0", Offset = "0x7C01FE0", VA = "0x187C035E0", Slot = "5")]
	public void GDCHFGOLPAL(string LNOMCAKIKIK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x7C03430", Offset = "0x7C01E30", VA = "0x187C03430", Slot = "6")]
	public string CKBEAJMHNKO(string CKPDINDGCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x7C03570", Offset = "0x7C01F70", VA = "0x187C03570")]
	private string ENBGFJBABMA(string CKPDINDGCNG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(RVA = "0x7C03A50", Offset = "0x7C02450", VA = "0x187C03A50")]
	public BILGIOGGOKC()
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
		public class LNIOCJHAKAG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			private Dictionary<string, Transform> GLJGILDAFHJ;

			[Cpp2IlInjected.Token(Token = "0x1700003D")]
			public bool LFELJFCAJBE
			{
				[Cpp2IlInjected.Token(Token = "0x6000111")]
				[Cpp2IlInjected.Address(RVA = "0x7C0B790", Offset = "0x7C0A190", VA = "0x187C0B790")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000112")]
			[Cpp2IlInjected.Address(RVA = "0x7C0B660", Offset = "0x7C0A060", VA = "0x187C0B660")]
			public void LKMMHCKPNEC(VRIK PKHNAANBDNG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0xA0C4B0", Offset = "0xA0AEB0", VA = "0x180A0C4B0")]
			public void JEKKKJEOKOC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x7C0B610", Offset = "0x7C0A010", VA = "0x187C0B610")]
			public void ALHGHPCNMCL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7C0B7D0", Offset = "0x7C0A1D0", VA = "0x187C0B7D0")]
			public LNIOCJHAKAG()
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
		[POCNOCJDEIG(MEAOHOOOBOD.SelfAndChildren, false, false, false)]
		[SerializeField]
		private Animator SkeletonAnimator;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[EMFMMKKCPNF(MEAOHOOOBOD.SelfAndChildren, false, false, false)]
		[SerializeField]
		private VRIK VRIKSolver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public ControllerExecMode ExecMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private readonly LNIOCJHAKAG OGIDFKPNADD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		private AADODDPPDOK BDNHMNMJCLN;

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x7C02D90", Offset = "0x7C01790", VA = "0x187C02D90")]
		private void DBILOAODCDE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7C02D40", Offset = "0x7C01740", VA = "0x187C02D40")]
		private bool AHNJJMIFPDF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x7C03070", Offset = "0x7C01A70", VA = "0x187C03070")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7C030E0", Offset = "0x7C01AE0", VA = "0x187C030E0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x7C03080", Offset = "0x7C01A80", VA = "0x187C03080")]
		[ContextMenu("Reset Pose")]
		public void ResetPose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x7C03350", Offset = "0x7C01D50", VA = "0x187C03350")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C06C70", Offset = "0x7C05670", VA = "0x187C06C70")]
			public (float, float) GMDJLFBAEEP(float CMDCMFEIFAK)
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
				[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
				[CompilerGenerated]
				get
				{
					return null;
				}
				[Cpp2IlInjected.Token(Token = "0x600011D")]
				[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x7C06360", Offset = "0x7C04D60", VA = "0x187C06360")]
			public void JBAOHJPBOCM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7C06440", Offset = "0x7C04E40", VA = "0x187C06440")]
			public (float, float) MNJELPLOEPN(Animator CAJBBACDMPF, AnimatorStateInfo CIDLPPOEBDF)
			{
				return default((float, float));
			}

			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C06580", Offset = "0x7C04F80", VA = "0x187C06580")]
		public void JBAOHJPBOCM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x7C069D0", Offset = "0x7C053D0", VA = "0x187C069D0")]
		public (float, float) MKBCNBLGCKE(Animator CAJBBACDMPF, JCAHGOLPIOM MMCFJCLCPGF, float OOEGKNPEALI)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C06770", Offset = "0x7C05170", VA = "0x187C06770")]
		private (float, float) JIHNEPAMDEG(Animator CAJBBACDMPF, AnimatorStateInfo CIDLPPOEBDF, JCAHGOLPIOM MMCFJCLCPGF, float OOEGKNPEALI)
		{
			return default((float, float));
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x7C06C60", Offset = "0x7C05660", VA = "0x187C06C60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C0D1D0", Offset = "0x7C0BBD0", VA = "0x187C0D1D0", Slot = "4")]
		public override void OnStateEnter(Animator CAJBBACDMPF, AnimatorStateInfo CIDLPPOEBDF, int JPLIMADECDF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7C0D330", Offset = "0x7C0BD30", VA = "0x187C0D330")]
		public MovementDirectionAnimationBehavior()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
internal abstract class FHNLEMHOCFF<TInput, TOutput> : MDPEBNNFNPI<TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	protected readonly HEILNANPDJC MNPKNCJLCKG;

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4B41320", Offset = "0x4B3FD20", VA = "0x184B41320")]
	protected FHNLEMHOCFF(HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(Slot = "6")]
	public abstract TOutput PGEPBAPICDN(TInput OKFHNJPHDOP, [Out] IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4B41280", Offset = "0x4B3FC80", VA = "0x184B41280", Slot = "5")]
	public bool APBMHMCKLLM(TInput OKFHNJPHDOP, [Out] TOutput? MGJNMKLFKCJ, [Out] IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[NHPBPJDIEFG]
public static class GHOKNKLPPGA
{
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	private static readonly Regex ELCHLPKAPED;

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x7C05D40", Offset = "0x7C04740", VA = "0x187C05D40")]
	public static GHFKODLDCCL DEPBIINAPJF(CODNEFMDLIN MEDDCGMBHDP, DGAJDHHBHCK GBFPFPKIGAG, Guid? LPOCINEMHOG, Color? PJICIENDCMN, MFEGJNCJJMB ODFAALAAHIH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x7C05F50", Offset = "0x7C04950", VA = "0x187C05F50")]
	public static OAJMHFIAABF ONCCJGEEGAA(GHFKODLDCCL HPGIDELCODH)
	{
		return default(OAJMHFIAABF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x3A694A0", Offset = "0x3A67EA0", VA = "0x183A694A0")]
	internal static TModern? ABCOLFDPLPD<TModern>(string? OKFHNJPHDOP, AJLEABMLMNA<TModern> NGMABMEMFAM, HEILNANPDJC MNPKNCJLCKG, HPMPLHOOJDM NBMPILFAAHG, TModern CEHPINIKCDM) where TModern : struct, OHCFANIPIDE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x3A6B970", Offset = "0x3A6A370", VA = "0x183A6B970")]
	internal static BCLNKMIIPEC CGGCHLLJJPL<TModern>(string? OKFHNJPHDOP, AJLEABMLMNA<TModern> NGMABMEMFAM, HEILNANPDJC MNPKNCJLCKG, HPMPLHOOJDM NBMPILFAAHG, TModern CEHPINIKCDM) where TModern : struct, OHCFANIPIDE
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x7C060B0", Offset = "0x7C04AB0", VA = "0x187C060B0")]
	internal static List<MOJBEEJFCOI> PIPHJFLMBCF(IEnumerable<DEIJGHOCENC>? GMBDHKCECLI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x3A6AAF0", Offset = "0x3A694F0", VA = "0x183A6AAF0")]
	internal static string ALNJBPGIMLB<TModern>(TModern OKFHNJPHDOP, AJLEABMLMNA<TModern> NGMABMEMFAM, HEILNANPDJC MNPKNCJLCKG) where TModern : OHCFANIPIDE
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal class NGDAFEELKCC : HJPLJLIANIE
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public MDPEBNNFNPI<GEMPBMEMGFC, HEFJDHOHCHF> PFFPMNBOBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xA0A560", Offset = "0xA08F60", VA = "0x180A0A560", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public MDPEBNNFNPI<IGPMACADNKG, NCOIOOIHPIG> AJFNAMBKECJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0", Slot = "7")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public MDPEBNNFNPI<IGPMACADNKG, NCOIOOIHPIG> GLNOJAEBOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0xA0A780", Offset = "0xA09180", VA = "0x180A0A780", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public NOPPALFCICK LNFPEAMJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0xA0A790", Offset = "0xA09190", VA = "0x180A0A790", Slot = "6")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public FHKNOJJJHHA CPOHJFGNPFN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0", Slot = "8")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D350", Offset = "0x7C0BD50", VA = "0x187C0D350")]
	[CGLGNCLDKHN.CKJOAALDIOP.OPIHCDHBMNP]
	[UsedImplicitly]
	internal static void BEEGBIHCEAF(MHGNCMHMEKD DJGDNAKMFCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x7C0D3C0", Offset = "0x7C0BDC0", VA = "0x187C0D3C0")]
	[RecRoom.NoEngine.Common.Preserve]
	internal NGDAFEELKCC([CNHMBDDCGKB("UnitySerialization")] MMNADCNNGKL IEBKNJEIPHO, [CNHMBDDCGKB(null)] ELAAHCCONCL LBDDHANJDAN, [CNHMBDDCGKB(null)] HEILNANPDJC MNPKNCJLCKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum FNEPBCAJLFJ
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
public class HDDDLNLIMNK : InvalidOperationException
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x7C06330", Offset = "0x7C04D30", VA = "0x187C06330")]
	public HDDDLNLIMNK(string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x7C062C0", Offset = "0x7C04CC0", VA = "0x187C062C0")]
	public HDDDLNLIMNK(string IJOJGNJMCGP, Exception ANDPNKJGGKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7C06290", Offset = "0x7C04C90", VA = "0x187C06290")]
	public HDDDLNLIMNK(FNEPBCAJLFJ PGBNNEFOMAE, string IJOJGNJMCGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C062F0", Offset = "0x7C04CF0", VA = "0x187C062F0")]
	public HDDDLNLIMNK(FNEPBCAJLFJ PGBNNEFOMAE, string IJOJGNJMCGP, Exception ANDPNKJGGKM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
internal abstract class LBJIDFHAHEN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	private readonly MMNADCNNGKL IEBKNJEIPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	protected readonly ELAAHCCONCL LBDDHANJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	protected readonly HEILNANPDJC MNPKNCJLCKG;

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0ABA0", Offset = "0x7C095A0", VA = "0x187C0ABA0")]
	protected LBJIDFHAHEN(MMNADCNNGKL IEBKNJEIPHO, ELAAHCCONCL LBDDHANJDAN, HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x7C095A0", Offset = "0x7C07FA0", VA = "0x187C095A0")]
	protected string DJHOAJMLBLK(HEFJDHOHCHF EJPDJBEBHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0A870", Offset = "0x7C09270", VA = "0x187C0A870")]
	protected string EIGAFDHEHLN(HEFJDHOHCHF EJPDJBEBHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x7C09270", Offset = "0x7C07C70", VA = "0x187C09270")]
	private AvatarOutfitSelectionData DEPBIINAPJF(GHFKODLDCCL JMMIPOIGPBG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AA60", Offset = "0x7C09460", VA = "0x187C0AA60")]
	private static AvatarCustomizationSettingsData.AnchorParams MEDOHACGHOI(EBGNPCDLBGE? FGDHFMBBPOC)
	{
		return default(AvatarCustomizationSettingsData.AnchorParams);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public interface MDPEBNNFNPI<in TInput, TOutput> where TOutput : class
{
	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(Slot = "0")]
	TOutput PGEPBAPICDN(TInput OKFHNJPHDOP, [Out] IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON);

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(Slot = "1")]
	bool APBMHMCKLLM(TInput OKFHNJPHDOP, [Out] TOutput? MGJNMKLFKCJ, [Out] IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON);
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public interface HJPLJLIANIE
{
	[Cpp2IlInjected.Token(Token = "0x17000044")]
	MDPEBNNFNPI<GEMPBMEMGFC, HEFJDHOHCHF> PFFPMNBOBKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	MDPEBNNFNPI<IGPMACADNKG, NCOIOOIHPIG> GLNOJAEBOEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	NOPPALFCICK LNFPEAMJIKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
internal enum HPMPLHOOJDM
{
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	UseNull,
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	UseEmpty,
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	Throw
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FHKNOJJJHHA
{
	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(Slot = "0")]
	HAJHKJGMGGF PGPOMLMDCHO(HEFJDHOHCHF HPGIDELCODH);
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public interface NOPPALFCICK
{
	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(Slot = "0")]
	IGPMACADNKG PGPOMLMDCHO(HEFJDHOHCHF HPGIDELCODH, int MFGDHAHMLOE, string? GBCFHNGPBLM, string? INLJMPKJBPJ, MCOEPIIJNLA LDPGNLMNBBL, List<MOJBEEJFCOI>? FEOFNCKAHON);
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[NHPBPJDIEFG]
internal class DEFOBMKCNDK : FHNLEMHOCFF<GEMPBMEMGFC, HEFJDHOHCHF>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	private readonly ELAAHCCONCL LBDDHANJDAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private readonly JANGKAOOIJO IIFIDMKEIAC;

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x7C03D80", Offset = "0x7C02780", VA = "0x187C03D80")]
	public DEFOBMKCNDK(MMNADCNNGKL IEBKNJEIPHO, ELAAHCCONCL LBDDHANJDAN, HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x7C03AE0", Offset = "0x7C024E0", VA = "0x187C03AE0", Slot = "6")]
	public override HEFJDHOHCHF PGEPBAPICDN(GEMPBMEMGFC OKFHNJPHDOP, [Out] IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[RecRoom.NoEngine.Common.Preserve]
internal class DMHMEMAAOEF : MMNADCNNGKL
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	private class LMIEDBKFOJH : JsonConverter<BCLNKMIIPEC>
	{
		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B530", Offset = "0x7C09F30", VA = "0x187C0B530", Slot = "9")]
		public override void WriteJson(JsonWriter EDJIMCINKFD, BCLNKMIIPEC? PCDAHJCDHHF, JsonSerializer IKCNAPIHBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B410", Offset = "0x7C09E10", VA = "0x187C0B410", Slot = "10")]
		public override BCLNKMIIPEC ReadJson(JsonReader LJMOCEGEAFH, Type FBCFFOEPLCL, BCLNKMIIPEC? MMHNNAODDAM, bool KNKIMHGOELG, JsonSerializer IKCNAPIHBJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x7C0B5D0", Offset = "0x7C09FD0", VA = "0x187C0B5D0")]
		public LMIEDBKFOJH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	private class EKBLMKMMKHN : JsonConverter
	{
		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override bool FCFLNDJENLN
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xA558D0", Offset = "0xA542D0", VA = "0x180A558D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7C04490", Offset = "0x7C02E90", VA = "0x187C04490", Slot = "5")]
		public override object ReadJson(JsonReader LJMOCEGEAFH, Type FBCFFOEPLCL, object? MMHNNAODDAM, JsonSerializer IKCNAPIHBJG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x7C040B0", Offset = "0x7C02AB0", VA = "0x187C040B0", Slot = "6")]
		public override bool CanConvert(Type FBCFFOEPLCL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x7C044F0", Offset = "0x7C02EF0", VA = "0x187C044F0", Slot = "4")]
		public override void WriteJson(JsonWriter EDJIMCINKFD, object? PCDAHJCDHHF, JsonSerializer IKCNAPIHBJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x7C04290", Offset = "0x7C02C90", VA = "0x187C04290")]
		private static bool JFONOBPOBIP(object PCDAHJCDHHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0xA34C70", Offset = "0xA33670", VA = "0x180A34C70")]
		public EKBLMKMMKHN()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	private readonly JsonSerializerSettings BKOBIBOAODL;

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x7C03F50", Offset = "0x7C02950", VA = "0x187C03F50")]
	internal DMHMEMAAOEF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x38D2E90", Offset = "0x38D1890", VA = "0x1838D2E90", Slot = "4")]
	public string LDGBPLMCAGM<T>(T OJDHMKOBKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x38D2EF0", Offset = "0x38D18F0", VA = "0x1838D2EF0", Slot = "5")]
	public T NKHFFNACILO<T>(string PCDAHJCDHHF)
	{
		return (T)null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[RecRoom.NoEngine.Common.Preserve]
internal class JMGLOBELEAF : MMNADCNNGKL
{
	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC480", Offset = "0x3ACAE80", VA = "0x183ACC480", Slot = "4")]
	public string LDGBPLMCAGM<T>(T OJDHMKOBKLD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC4E0", Offset = "0x3ACAEE0", VA = "0x183ACC4E0", Slot = "5")]
	public T NKHFFNACILO<T>(string PCDAHJCDHHF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
	public JMGLOBELEAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
[NHPBPJDIEFG]
internal class JANGKAOOIJO : FHNLEMHOCFF<IGPMACADNKG, NCOIOOIHPIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	private readonly MMNADCNNGKL IEBKNJEIPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	private readonly ELAAHCCONCL LBDDHANJDAN;

	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x7C09130", Offset = "0x7C07B30", VA = "0x187C09130")]
	public JANGKAOOIJO(MMNADCNNGKL IEBKNJEIPHO, ELAAHCCONCL LBDDHANJDAN, HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x7C08080", Offset = "0x7C06A80", VA = "0x187C08080", Slot = "6")]
	public override NCOIOOIHPIG PGEPBAPICDN(IGPMACADNKG OKFHNJPHDOP, [Out] IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x7C06D30", Offset = "0x7C05730", VA = "0x187C06D30")]
	internal void BNLFJCPKMJL(string BNCABIIPKLI, HEFJDHOHCHF EJPDJBEBHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x7C07E70", Offset = "0x7C06870", VA = "0x187C07E70")]
	public IEnumerable<GHFKODLDCCL> LHKIHNFNOEP(string KJKDOFLMDBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x7C08D20", Offset = "0x7C07720", VA = "0x187C08D20")]
	private IEnumerable<GHFKODLDCCL> PKMDNCHCCNI(string KJKDOFLMDBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x7C06E80", Offset = "0x7C05880", VA = "0x187C06E80")]
	internal IEnumerable<GHFKODLDCCL> CDDHGKCKEKG(string KJKDOFLMDBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x7C07AF0", Offset = "0x7C064F0", VA = "0x187C07AF0")]
	private GHFKODLDCCL KKPFJIHPNDA(AvatarOutfitSelectionData CMNKNFKDEBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x7C084A0", Offset = "0x7C06EA0", VA = "0x187C084A0")]
	private void PGONFIDMMPP(AvatarCustomizationSettingsData BLPNOKINKCA, HEFJDHOHCHF EJPDJBEBHDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x7C077D0", Offset = "0x7C061D0", VA = "0x187C077D0")]
	private GHFKODLDCCL KKPFJIHPNDA(string NJAGCAICGND)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x7C072D0", Offset = "0x7C05CD0", VA = "0x187C072D0")]
	internal static (MFEGJNCJJMB, string, string) EPMJKMGDDHF(string NJAGCAICGND, HEILNANPDJC MNPKNCJLCKG)
	{
		return default((MFEGJNCJJMB, string, string));
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x7C075D0", Offset = "0x7C05FD0", VA = "0x187C075D0")]
	private BHLDDBLCIKF? JEEIAIAKOCE(string? FNKCCICOAII, Vector2 ABHKONGANMG, float IMBEPCLHEJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x7C07F20", Offset = "0x7C06920", VA = "0x187C07F20")]
	private static EBGNPCDLBGE PDHKIGKBNOI(AvatarCustomizationSettingsData.AnchorParams OGNOJFKDEKJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
[NHPBPJDIEFG]
internal class LIIKGNCCOIJ : LBJIDFHAHEN, FHKNOJJJHHA
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x7C0ABA0", Offset = "0x7C095A0", VA = "0x187C0ABA0")]
	public LIIKGNCCOIJ(MMNADCNNGKL IEBKNJEIPHO, ELAAHCCONCL LBDDHANJDAN, HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B060", Offset = "0x7C09A60", VA = "0x187C0B060", Slot = "4")]
	public HAJHKJGMGGF PGPOMLMDCHO(HEFJDHOHCHF HPGIDELCODH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AD20", Offset = "0x7C09720", VA = "0x187C0AD20")]
	private string AGKEOKIHDBL(HEFJDHOHCHF EJPDJBEBHDF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x7C0AE20", Offset = "0x7C09820", VA = "0x187C0AE20")]
	private string DNHDIIKMLIP(GHFKODLDCCL JMMIPOIGPBG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
[NHPBPJDIEFG]
internal class FHJKNBJDONI : FHNLEMHOCFF<IGPMACADNKG, NCOIOOIHPIG>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private readonly MMNADCNNGKL IEBKNJEIPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private readonly MDPEBNNFNPI<IGPMACADNKG, NCOIOOIHPIG> GFMDACMEPNC;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x7C04A00", Offset = "0x7C03400", VA = "0x187C04A00")]
	public FHJKNBJDONI(MDPEBNNFNPI<IGPMACADNKG, NCOIOOIHPIG> GFMDACMEPNC, HEILNANPDJC MNPKNCJLCKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x7C045D0", Offset = "0x7C02FD0", VA = "0x187C045D0", Slot = "6")]
	public override NCOIOOIHPIG PGEPBAPICDN(IGPMACADNKG OKFHNJPHDOP, [Out] IReadOnlyList<MOJBEEJFCOI>? FEOFNCKAHON)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
[NHPBPJDIEFG]
internal class GGDHMDONIKK : NOPPALFCICK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private readonly MMNADCNNGKL IEBKNJEIPHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	private readonly FHKNOJJJHHA COCEAMAKJDN;

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x7C05C50", Offset = "0x7C04650", VA = "0x187C05C50")]
	public GGDHMDONIKK(FHKNOJJJHHA COCEAMAKJDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x7C058B0", Offset = "0x7C042B0", VA = "0x187C058B0", Slot = "4")]
	public IGPMACADNKG PGPOMLMDCHO(HEFJDHOHCHF HPGIDELCODH, int MFGDHAHMLOE, string? GBCFHNGPBLM, string? INLJMPKJBPJ, MCOEPIIJNLA LDPGNLMNBBL, List<MOJBEEJFCOI>? FEOFNCKAHON)
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
		[Cpp2IlInjected.Address(RVA = "0x7C02400", Offset = "0x7C00E00", VA = "0x187C02400")]
		public void PlayCurrentStates()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0xA0C4A0", Offset = "0xA0AEA0", VA = "0x180A0C4A0")]
		public AnimatorDebugUtil()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public static class MCNGPGDMAOL
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B8C0", Offset = "0x7C0A2C0", VA = "0x187C0B8C0")]
	public static OAJMHFIAABF PGEPBAPICDN(this JLNENFKHAEA HPGIDELCODH)
	{
		return default(OAJMHFIAABF);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B9D0", Offset = "0x7C0A3D0", VA = "0x187C0B9D0")]
	public static JLNENFKHAEA PGPOMLMDCHO(this OAJMHFIAABF IPCJKIPJBHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x7C0B860", Offset = "0x7C0A260", VA = "0x187C0B860")]
	public static bool GOFMBNMHKGC(this OAJMHFIAABF IPCJKIPJBHL)
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
			[Cpp2IlInjected.Address(RVA = "0x5D67D60", Offset = "0x5D66760", VA = "0x185D67D60")]
			public AnchorParams(Vector2 OOBIJOPNFKK, Vector3 AKCBONMCJIM, Vector3 IBPCJOIMPJP)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001AF")]
			[Cpp2IlInjected.Address(RVA = "0x7C02350", Offset = "0x7C00D50", VA = "0x187C02350")]
			internal EBGNPCDLBGE PGPOMLMDCHO()
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
		private GHNNHOLHIND useHelmetHair;

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
			[Cpp2IlInjected.Address(RVA = "0x7C02BF0", Offset = "0x7C015F0", VA = "0x187C02BF0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string? EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600017D")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600017E")]
			[Cpp2IlInjected.Address(RVA = "0xA0A7B0", Offset = "0xA091B0", VA = "0x180A0A7B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600017F")]
			[Cpp2IlInjected.Address(RVA = "0x1722800", Offset = "0x1721200", VA = "0x181722800")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000180")]
			[Cpp2IlInjected.Address(RVA = "0xD5A430", Offset = "0xD58E30", VA = "0x180D5A430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000181")]
			[Cpp2IlInjected.Address(RVA = "0xF20A20", Offset = "0xF1F420", VA = "0x180F20A20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000182")]
			[Cpp2IlInjected.Address(RVA = "0x1424210", Offset = "0x1422C10", VA = "0x181424210")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public string? EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000183")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000184")]
			[Cpp2IlInjected.Address(RVA = "0xA14650", Offset = "0xA13050", VA = "0x180A14650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x7C02C90", Offset = "0x7C01690", VA = "0x187C02C90")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000186")]
			[Cpp2IlInjected.Address(RVA = "0xA0A580", Offset = "0xA08F80", VA = "0x180A0A580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000187")]
			[Cpp2IlInjected.Address(RVA = "0xC98720", Offset = "0xC97120", VA = "0x180C98720")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000188")]
			[Cpp2IlInjected.Address(RVA = "0xC98380", Offset = "0xC96D80", VA = "0x180C98380")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public string? NoseGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000189")]
			[Cpp2IlInjected.Address(RVA = "0xA091E0", Offset = "0xA07BE0", VA = "0x180A091E0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600018A")]
			[Cpp2IlInjected.Address(RVA = "0xA09180", Offset = "0xA07B80", VA = "0x180A09180")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 NosePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018B")]
			[Cpp2IlInjected.Address(RVA = "0x7C02CD0", Offset = "0x7C016D0", VA = "0x187C02CD0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600018C")]
			[Cpp2IlInjected.Address(RVA = "0xED7640", Offset = "0xED6040", VA = "0x180ED7640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public float NoseScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600018D")]
			[Cpp2IlInjected.Address(RVA = "0x113EFF0", Offset = "0x113D9F0", VA = "0x18113EFF0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600018E")]
			[Cpp2IlInjected.Address(RVA = "0x18C7C50", Offset = "0x18C6650", VA = "0x1818C7C50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public string? MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600018F")]
			[Cpp2IlInjected.Address(RVA = "0xA10520", Offset = "0xA0EF20", VA = "0x180A10520")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0xA10510", Offset = "0xA0EF10", VA = "0x180A10510")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x24098E0", Offset = "0x24082E0", VA = "0x1824098E0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000192")]
			[Cpp2IlInjected.Address(RVA = "0xF01840", Offset = "0xF00240", VA = "0x180F01840")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0xA41F80", Offset = "0xA40980", VA = "0x180A41F80")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000194")]
			[Cpp2IlInjected.Address(RVA = "0xA41FE0", Offset = "0xA409E0", VA = "0x180A41FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public string? HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000195")]
			[Cpp2IlInjected.Address(RVA = "0xA092C0", Offset = "0xA07CC0", VA = "0x180A092C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000196")]
			[Cpp2IlInjected.Address(RVA = "0xA09160", Offset = "0xA07B60", VA = "0x180A09160")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string? HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000197")]
			[Cpp2IlInjected.Address(RVA = "0xA09190", Offset = "0xA07B90", VA = "0x180A09190")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000198")]
			[Cpp2IlInjected.Address(RVA = "0xA09280", Offset = "0xA07C80", VA = "0x180A09280")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public string? HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000199")]
			[Cpp2IlInjected.Address(RVA = "0xA09220", Offset = "0xA07C20", VA = "0x180A09220")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019A")]
			[Cpp2IlInjected.Address(RVA = "0xA09300", Offset = "0xA07D00", VA = "0x180A09300")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public string? BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019B")]
			[Cpp2IlInjected.Address(RVA = "0xA6E210", Offset = "0xA6CC10", VA = "0x180A6E210")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019C")]
			[Cpp2IlInjected.Address(RVA = "0xA6B540", Offset = "0xA69F40", VA = "0x180A6B540")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public string? BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019D")]
			[Cpp2IlInjected.Address(RVA = "0xA091A0", Offset = "0xA07BA0", VA = "0x180A091A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600019E")]
			[Cpp2IlInjected.Address(RVA = "0xA092A0", Offset = "0xA07CA0", VA = "0x180A092A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public string? BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0xA6E630", Offset = "0xA6D030", VA = "0x180A6E630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A0")]
			[Cpp2IlInjected.Address(RVA = "0xA87000", Offset = "0xA85A00", VA = "0x180A87000")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string? FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3B0", Offset = "0xA0BDB0", VA = "0x180A0D3B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A2")]
			[Cpp2IlInjected.Address(RVA = "0xA0D3C0", Offset = "0xA0BDC0", VA = "0x180A0D3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public string? BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001A3")]
			[Cpp2IlInjected.Address(RVA = "0xA86FF0", Offset = "0xA859F0", VA = "0x180A86FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001A4")]
			[Cpp2IlInjected.Address(RVA = "0xA871F0", Offset = "0xA85BF0", VA = "0x180A871F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001A5")]
			[Cpp2IlInjected.Address(RVA = "0xCFF770", Offset = "0xCFE170", VA = "0x180CFF770")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0xCFB640", Offset = "0xCFA040", VA = "0x180CFB640")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public GHNNHOLHIND UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0xF9F9F0", Offset = "0xF9E3F0", VA = "0x180F9F9F0")]
			get
			{
				return default(GHNNHOLHIND);
			}
			[Cpp2IlInjected.Token(Token = "0x60001A8")]
			[Cpp2IlInjected.Address(RVA = "0xF9EDB0", Offset = "0xF9D7B0", VA = "0x180F9EDB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0xF9E1F0", Offset = "0xF9CBF0", VA = "0x180F9E1F0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AA")]
			[Cpp2IlInjected.Address(RVA = "0xC65AC0", Offset = "0xC644C0", VA = "0x180C65AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x60001AB")]
			[Cpp2IlInjected.Address(RVA = "0x7C02CB0", Offset = "0x7C016B0", VA = "0x187C02CB0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x60001AC")]
			[Cpp2IlInjected.Address(RVA = "0x7C02CF0", Offset = "0x7C016F0", VA = "0x187C02CF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x7C02890", Offset = "0x7C01290", VA = "0x187C02890")]
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
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
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
		public MFEGJNCJJMB BodyPart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001C4")]
		public AvatarUgcOutfitData? UgcOutfitData;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001C5")]
		private FMEOGEBJMFH? _materialCombinationId;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public string? DEPRECATED_CombinationGuid
		{
			[Cpp2IlInjected.Token(Token = "0x60001B1")]
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x7C02D10", Offset = "0x7C01710", VA = "0x187C02D10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
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
		[Cpp2IlInjected.Address(RVA = "0xA104F0", Offset = "0xA0EEF0", VA = "0x180A104F0")]
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
