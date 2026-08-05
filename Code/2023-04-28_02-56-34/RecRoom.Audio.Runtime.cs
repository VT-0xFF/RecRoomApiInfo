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
	[Cpp2IlInjected.Address(RVA = "0x69D1B00", Offset = "0x69D0500", VA = "0x1869D1B00")]
	public APFPEEBOPEB(HMPKJCPKEBK CGMCFAMDMHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x69D1A90", Offset = "0x69D0490", VA = "0x1869D1A90")]
	public APFPEEBOPEB(HMPKJCPKEBK CGMCFAMDMHF, string GHLJDNNGEPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x69D1A00", Offset = "0x69D0400", VA = "0x1869D1A00")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D1C40", Offset = "0x69D0640", VA = "0x1869D1C40")]
	public static void HGJCLPGEAGD(this AudioSource GHKNOFNOKLM, AudioRolloff ALENNCMAHBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x69D1D00", Offset = "0x69D0700", VA = "0x1869D1D00")]
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
	[Cpp2IlInjected.Address(RVA = "0x69D1BC0", Offset = "0x69D05C0", VA = "0x1869D1BC0")]
	public static float EFMJKIHDMMP(float MCIECPMIEEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x69D1C10", Offset = "0x69D0610", VA = "0x1869D1C10")]
	public static float PKMHDDLDIFD(float GDNAJMMOPDM)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
		[Cpp2IlInjected.Address(RVA = "0x69D1BA0", Offset = "0x69D05A0", VA = "0x1869D1BA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x69D2D60", Offset = "0x69D1760", VA = "0x1869D2D60")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x69D2DF0", Offset = "0x69D17F0", VA = "0x1869D2DF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x69D2D00", Offset = "0x69D1700", VA = "0x1869D2D00")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x69D2DA0", Offset = "0x69D17A0", VA = "0x1869D2DA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x69D2CB0", Offset = "0x69D16B0", VA = "0x1869D2CB0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x69D2CC0", Offset = "0x69D16C0", VA = "0x1869D2CC0")]
		public RecRoomAudioClip(AudioClip FHBLOEDICNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x69D2B40", Offset = "0x69D1540", VA = "0x1869D2B40")]
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
			[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x69D2A70", Offset = "0x69D1470", VA = "0x1869D2A70")]
		public bool PPENLNDLJME()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0xDC40C0", Offset = "0xDC2AC0", VA = "0x180DC40C0")]
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
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private const float BIDBIKALGIP = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private const float KCMLIEJLGGJ = 1f;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private const HMPKJCPKEBK GNMDINCDELD = HMPKJCPKEBK.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public float? JAGGMGLENIB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? PHJDKKEEKMM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public Vector3 GIKDKNNOHKC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Transform NAIJJMFPCOF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public AudioRolloff JAPBHHBDKKK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public float JKBPFLBMAEB;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float IONNFAKLAFM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public HMPKJCPKEBK? JFBPBFKCCND;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public float FFDEAMFPCIN
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x69D1DD0", Offset = "0x69D07D0", VA = "0x1869D1DD0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public HMPKJCPKEBK GCKANHNMEMH
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x69D1E60", Offset = "0x69D0860", VA = "0x1869D1E60")]
				get
				{
					return default(HMPKJCPKEBK);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct MPONDPNDENC : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public EJODJAGNGDP playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x69D25E0", Offset = "0x69D0FE0", VA = "0x1869D25E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x8D6410", Offset = "0x8D4E10", VA = "0x1808D6410", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class JJAGBNFDGIC : IEnumerator<MEOADLJIECK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private MEOADLJIECK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private MEOADLJIECK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003A")]
				[Cpp2IlInjected.Address(RVA = "0x727030", Offset = "0x725A30", VA = "0x180727030", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x80F8E0", Offset = "0x80E2E0", VA = "0x18080F8E0")]
			[DebuggerHidden]
			public JJAGBNFDGIC(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x72A830", Offset = "0x729230", VA = "0x18072A830", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x69D1EB0", Offset = "0x69D08B0", VA = "0x1869D1EB0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x69D1F70", Offset = "0x69D0970", VA = "0x1869D1F70", Slot = "8")]
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
		private AudioSource _audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private LGIHGHKPCKA NEAFKGIGDKB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private MOPAADIODPO OCOCCJFBELF;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const string JDKMGJEEEEM = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform NAIJJMFPCOF
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x727000", Offset = "0x725A00", VA = "0x180727000")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7A9630", Offset = "0x7A8030", VA = "0x1807A9630")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioSource FICMBFCMKCF
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x731A10", Offset = "0x730410", VA = "0x180731A10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x69D2E70", Offset = "0x69D1870", VA = "0x1869D2E70")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x69D3600", Offset = "0x69D2000", VA = "0x1869D3600")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E50", Offset = "0x69D2850", VA = "0x1869D3E50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x69D3890", Offset = "0x69D2290", VA = "0x1869D3890")]
		public void Play(AudioClip FHBLOEDICNL, float HPPFKDHHKPC, Vector3 JDJHGHDNLLP, float CKDAOFKDIGL, float ONJGJMIGOFB, AudioRolloff ALENNCMAHBN, [Optional] Action<SFXAudioSource> ENLBCAPFMBJ, [Optional] APFPEEBOPEB? CGMCFAMDMHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x69D3720", Offset = "0x69D2120", VA = "0x1869D3720")]
		[AsyncStateMachine(typeof(MPONDPNDENC))]
		public Task PlayAsync(AudioClip FHBLOEDICNL, EJODJAGNGDP FFIPBCMDCOF, CancellationToken OIMNLGJCBEC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x69D2F70", Offset = "0x69D1970", VA = "0x1869D2F70")]
		private void JLLCEBBAOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x69D35B0", Offset = "0x69D1FB0", VA = "0x1869D35B0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x69D3DB0", Offset = "0x69D27B0", VA = "0x1869D3DB0")]
		public void Scrub(float LAOEDLDFAJL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x69D3E10", Offset = "0x69D2810", VA = "0x1869D3E10")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x69D2F10", Offset = "0x69D1910", VA = "0x1869D2F10")]
		public void CancelAudioSourceRelease()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x69D3CC0", Offset = "0x69D26C0", VA = "0x1869D3CC0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x69D3C50", Offset = "0x69D2650", VA = "0x1869D3C50")]
		[IteratorStateMachine(typeof(JJAGBNFDGIC))]
		public IEnumerator<MEOADLJIECK> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x69D2F60", Offset = "0x69D1960", VA = "0x1869D2F60", Slot = "4")]
		private void DBPFGMKGOFB(bool KHJHBNPBBAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0xE67660", Offset = "0xE66060", VA = "0x180E67660")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class KKMDFNBFHNC
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] BKNPCMHFKCN;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int KPMJKGHHDMP;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int JFAKBFOPBGJ;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger JMHPFPLGCJL;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
	public KKMDFNBFHNC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x69D2300", Offset = "0x69D0D00", VA = "0x1869D2300")]
	private static string JOPJDHMEFPC(byte[] GFCGIJPPCBN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x69D1FB0", Offset = "0x69D09B0", VA = "0x1869D1FB0")]
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

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
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
