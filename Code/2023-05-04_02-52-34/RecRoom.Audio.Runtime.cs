using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom.Audio;
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HOOAIPHGFPD
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum BPBCCMDAHJA
{
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	LowPitch = 0,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	None = 1,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	HighPitch = 2,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	RadioLowPitch = 10,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	Radio = 11,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	RadioHighPitch = 12
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum HMPKJCPKEBK
{
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Ambience
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct APFPEEBOPEB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly HMPKJCPKEBK JFBPBFKCCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly string NDKKIBBKDOA;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x69E16D0", Offset = "0x69E0AD0", VA = "0x1869E16D0")]
	public APFPEEBOPEB(HMPKJCPKEBK CGMCFAMDMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69E1660", Offset = "0x69E0A60", VA = "0x1869E1660")]
	public APFPEEBOPEB(HMPKJCPKEBK CGMCFAMDMHF, string GHLJDNNGEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69E15D0", Offset = "0x69E09D0", VA = "0x1869E15D0")]
	public bool LLCCFABBGAP(HMPKJCPKEBK FELKNAKNOKP, string EHGLAHMDPNI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum JLOHHHMMBHH
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class DILIABKOPPA
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x69E1810", Offset = "0x69E0C10", VA = "0x1869E1810")]
	public static void HGJCLPGEAGD(this AudioSource GHKNOFNOKLM, AudioRolloff ALENNCMAHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69E18D0", Offset = "0x69E0CD0", VA = "0x1869E18D0")]
	public static void PDAFEMMNACP(this AudioSource NJHJOPJEPFE, RecRoomAudioClip ACLGJEJGOAM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class COKKPAPNCKF
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const float DHLMEMAPCDP = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const float CPAJNBAPIPL = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x69E1790", Offset = "0x69E0B90", VA = "0x1869E1790")]
	public static float EFMJKIHDMMP(float MCIECPMIEEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69E17E0", Offset = "0x69E0BE0", VA = "0x1869E17E0")]
	public static float PKMHDDLDIFD(float GDNAJMMOPDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public COKKPAPNCKF()
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x69E1770", Offset = "0x69E0B70", VA = "0x1869E1770")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MOPAADIODPO
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int OLPIFAKJOLE
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, CPFMMOODPIE> CGBHMOGCAOA();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, APFPEEBOPEB)> IOKDBMNFIKI();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup AEJFCMABIAG(HMPKJCPKEBK CGMCFAMDMHF);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup MCPPEHOOPOE(APFPEEBOPEB PBFHMFLKHJJ);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HGJCLPGEAGD(AudioSource NJHJOPJEPFE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource KFIMBNBOGPD(RecRoomAudioClip LACPHFNDMPI, Transform JBOFBHPJFBN, [Optional] AudioRolloff CMHBEFMMECL, [Optional] Action<SFXAudioSource> EELJDNMMKEB, [Optional] APFPEEBOPEB? CGMCFAMDMHF);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void GLBDELLFJPH(SFXAudioSource NJHJOPJEPFE);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource OFBBLDIKBBP(RecRoomAudioClip[] ONAOFKPMLOB, bool GBKHBDNDBIE = false, float GBOAIBBLINA = 1f, [Optional] Action<SFXAudioSource> EELJDNMMKEB, [Optional] APFPEEBOPEB? CGMCFAMDMHF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource EKHBMBCPJNA(RecRoomAudioClip[] ONAOFKPMLOB, Transform JBOFBHPJFBN, [Optional] AudioRolloff CMHBEFMMECL, bool GBKHBDNDBIE = false, [Optional] Action<SFXAudioSource> EELJDNMMKEB, [Optional] APFPEEBOPEB? CGMCFAMDMHF);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource JBGALCOHJBM(RecRoomAudioClip MBEEJMLAPEL, Vector3 JDJHGHDNLLP, bool DGEBDCMICMB, [Optional] AudioRolloff CMHBEFMMECL, [Optional] Action<SFXAudioSource> EELJDNMMKEB, [Optional] APFPEEBOPEB? CGMCFAMDMHF);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource NOOLEEBNFKL(RecRoomAudioClip FHBLOEDICNL, [Optional] Action<SFXAudioSource> EELJDNMMKEB, [Optional] APFPEEBOPEB? CGMCFAMDMHF);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Header("Pitch")]
		[Range(0f, 0f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x69E24A0", Offset = "0x69E18A0", VA = "0x1869E24A0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x69E2530", Offset = "0x69E1930", VA = "0x1869E2530")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69E2440", Offset = "0x69E1840", VA = "0x1869E2440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x69E24E0", Offset = "0x69E18E0", VA = "0x1869E24E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69E23F0", Offset = "0x69E17F0", VA = "0x1869E23F0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69E2400", Offset = "0x69E1800", VA = "0x1869E2400")]
		public RecRoomAudioClip(AudioClip FHBLOEDICNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69E2280", Offset = "0x69E1680", VA = "0x1869E2280")]
		public bool AFDJOPCPCOF(RecRoomAudioClip MPHACEGLFIL)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69E21B0", Offset = "0x69E15B0", VA = "0x1869E21B0")]
		public bool PPENLNDLJME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xC5D680", Offset = "0xC5CA80", VA = "0x180C5D680")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, JNEFBJKEDGC.AOIEMHPAACF
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct EJODJAGNGDP
		{
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private const float BIDBIKALGIP = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x400002D")]
			private const float KCMLIEJLGGJ = 1f;

			[Cpp2IlInjected.Token(Token = "0x400002E")]
			private const HMPKJCPKEBK GNMDINCDELD = HMPKJCPKEBK.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? JAGGMGLENIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float? PHJDKKEEKMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Vector3 GIKDKNNOHKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public Transform NAIJJMFPCOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AudioRolloff JAPBHHBDKKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float JKBPFLBMAEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public float IONNFAKLAFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public HMPKJCPKEBK? JFBPBFKCCND;

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public float FFDEAMFPCIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000039")]
				[Cpp2IlInjected.Address(RVA = "0x69E19A0", Offset = "0x69E0DA0", VA = "0x1869E19A0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			public HMPKJCPKEBK GCKANHNMEMH
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x69E1A30", Offset = "0x69E0E30", VA = "0x1869E1A30")]
				get
				{
					return default(HMPKJCPKEBK);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct AEDNBLBGIGD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public EJODJAGNGDP playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x69E10C0", Offset = "0x69E04C0", VA = "0x1869E10C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xE5A0A0", Offset = "0xE594A0", VA = "0x180E5A0A0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class OBANLBAJPNH : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000040")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000E")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000042")]
				[Cpp2IlInjected.Address(RVA = "0x72B030", Offset = "0x72A430", VA = "0x18072B030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x7E5540", Offset = "0x7E4940", VA = "0x1807E5540")]
			[DebuggerHidden]
			public OBANLBAJPNH(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x72E830", Offset = "0x72DC30", VA = "0x18072E830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0x69E20B0", Offset = "0x69E14B0", VA = "0x1869E20B0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x69E2170", Offset = "0x69E1570", VA = "0x1869E2170", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		private Action<SFXAudioSource> ACBJEHBHOFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private PLALJAJNMKE AINHNCNMHOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[EPAJBOKMDOH(DIMAPHHKBON.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private LGIHGHKPCKA NEAFKGIGDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private MOPAADIODPO OCOCCJFBELF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private float PJOCCKAJHBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private float MBNBFFBJDMN;

		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private const string JDKMGJEEEEM = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform NAIJJMFPCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x72B000", Offset = "0x72A400", VA = "0x18072B000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0D30", VA = "0x1807B1930")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int JAKDOMMEFNI
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x69E3CB0", Offset = "0x69E30B0", VA = "0x1869E3CB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool CDPMEFPMEMO
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x69E3DA0", Offset = "0x69E31A0", VA = "0x1869E3DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public bool KEBNJICEEPH
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x69E3D80", Offset = "0x69E3180", VA = "0x1869E3D80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float JAGGMGLENIB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x69E3DC0", Offset = "0x69E31C0", VA = "0x1869E3DC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public float JHHAFCAHENF
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x69E3CD0", Offset = "0x69E30D0", VA = "0x1869E3CD0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69E25B0", Offset = "0x69E19B0", VA = "0x1869E25B0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69E2E90", Offset = "0x69E2290", VA = "0x1869E2E90")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69E3BE0", Offset = "0x69E2FE0", VA = "0x1869E3BE0")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69E3BC0", Offset = "0x69E2FC0", VA = "0x1869E3BC0")]
		public void UpdateVolume(float HPPFKDHHKPC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69E39A0", Offset = "0x69E2DA0", VA = "0x1869E39A0")]
		public void UpdatePitch(float EAJHBBJANLP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69E3900", Offset = "0x69E2D00", VA = "0x1869E3900")]
		public void UpdateDopplerLevel(float BMHOBDELDMA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69E3B20", Offset = "0x69E2F20", VA = "0x1869E3B20")]
		public void UpdateSpatialBlend(float JGGHCCGGGBP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69E3830", Offset = "0x69E2C30", VA = "0x1869E3830")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69E31A0", Offset = "0x69E25A0", VA = "0x1869E31A0")]
		public void Play(AudioClip FHBLOEDICNL, float HPPFKDHHKPC, Vector3 JDJHGHDNLLP, float CKDAOFKDIGL, float ONJGJMIGOFB, AudioRolloff ALENNCMAHBN, [Optional] Action<SFXAudioSource> ENLBCAPFMBJ, [Optional] APFPEEBOPEB? CGMCFAMDMHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x69E3030", Offset = "0x69E2430", VA = "0x1869E3030")]
		[AsyncStateMachine(typeof(AEDNBLBGIGD))]
		public Task PlayAsync(AudioClip FHBLOEDICNL, EJODJAGNGDP FFIPBCMDCOF, CancellationToken OIMNLGJCBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x69E2680", Offset = "0x69E1A80", VA = "0x1869E2680")]
		private void JLLCEBBAOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x69E2E40", Offset = "0x69E2240", VA = "0x1869E2E40")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x69E3860", Offset = "0x69E2C60", VA = "0x1869E3860")]
		public void Scrub(float LAOEDLDFAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x69E38C0", Offset = "0x69E2CC0", VA = "0x1869E38C0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x69E3710", Offset = "0x69E2B10", VA = "0x1869E3710")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x69E36A0", Offset = "0x69E2AA0", VA = "0x1869E36A0")]
		[IteratorStateMachine(typeof(OBANLBAJPNH))]
		public IEnumerator<MEOADLJIECK> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x69E2670", Offset = "0x69E1A70", VA = "0x1869E2670", Slot = "4")]
		private void DBPFGMKGOFB(bool KHJHBNPBBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0xC4F540", Offset = "0xC4E940", VA = "0x180C4F540")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x69E1DD0", Offset = "0x69E11D0", VA = "0x1869E1DD0")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x69E1A80", Offset = "0x69E0E80", VA = "0x1869E1A80")]
	public static string GLIIACIKPKK(byte[] EMIAMELGKNF, bool LLPOIDPCGKE)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000013")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000045")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x72E810", Offset = "0x72DC10", VA = "0x18072E810")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
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
