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
using RecRoom.Audio;
using UnityEngine;
using UnityEngine.Audio;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public enum HFJPDDILADK
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum MMOPGNJLBKE
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
	RadioHighPitch = 12,
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	LoudspeakerLowPitch = 20,
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	Loudspeaker = 21,
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	LoudspeakerHighPitch = 22
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public enum NFPCPANDOBP
{
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	Voice,
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	Sfx,
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Music,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Ambience
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct FELLLMIMJEO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly NFPCPANDOBP MECHCFAECIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string LECNGFKFCAN;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AAC0", Offset = "0x5F998C0", VA = "0x185F9AAC0")]
	public FELLLMIMJEO(NFPCPANDOBP OMBFAFMLKCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5F9AA50", Offset = "0x5F99850", VA = "0x185F9AA50")]
	public FELLLMIMJEO(NFPCPANDOBP OMBFAFMLKCL, string GNPAKFLDINK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A9C0", Offset = "0x5F997C0", VA = "0x185F9A9C0")]
	public bool IAACAHJAOHE(NFPCPANDOBP ABDDCKNIEIL, string AIOELBCGNEB)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum EOGOJOCOBHI
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class EMIDADKOMIC
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A900", Offset = "0x5F99700", VA = "0x185F9A900")]
	public static void OLCOIBMAJNO(this AudioSource OHOGHLPFBBH, AudioRolloff IIKNDNDMMNG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class BCEDJFHOICA
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A860", Offset = "0x5F99660", VA = "0x185F9A860")]
	public static float LMOAFKIADKH(float KFJNFPEDBIP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5F9A8C0", Offset = "0x5F996C0", VA = "0x185F9A8C0")]
	public static float LOMNFEGFEJA(float GONGEKBAPIK)
	{
		return default(float);
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private const float ROLL_OFF_SCALE = 1f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve. Distance(x axis) in this curve is normalized.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x5F9A580", Offset = "0x5F99380", VA = "0x185F9A580")]
		public float DGIDCGJDHHM(float JLPKLILLGMH)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x5F9A840", Offset = "0x5F99640", VA = "0x185F9A840")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface KLFANNGJHOI
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int HAIHICLFIDO
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, HPAOIMDDOHC> GAHJHIBOOIE();

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, FELLLMIMJEO)> HDPHEMJDCJN();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup JFJGPOHJDDI(NFPCPANDOBP OMBFAFMLKCL);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup FHFFAIHJIAM(FELLLMIMJEO GHCHFIMICIK);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource IEKGFOAOJCJ(RecRoomAudioClip BEHAOFBHFCI, Transform PMFAJEJGLFM, [Optional] AudioRolloff DBPEGBOJAMO, [Optional] Action<SFXAudioSource> KAMEFBBABKD, [Optional] FELLLMIMJEO? OMBFAFMLKCL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void PKOBMKGOIOJ(SFXAudioSource HPBFAHDNKIH);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource GCPKIGGHLPM(RecRoomAudioClip[] NAGDFJLHCAK, bool DMMMCPGPPOM = false, float HNOOOLMKLCP = 1f, [Optional] Action<SFXAudioSource> KAMEFBBABKD, [Optional] FELLLMIMJEO? OMBFAFMLKCL);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource PIOEBFKCCJI(RecRoomAudioClip[] NAGDFJLHCAK, Transform PMFAJEJGLFM, [Optional] AudioRolloff DBPEGBOJAMO, bool DMMMCPGPPOM = false, [Optional] Action<SFXAudioSource> KAMEFBBABKD, [Optional] FELLLMIMJEO? OMBFAFMLKCL);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource MFELDPKAJNP(RecRoomAudioClip KBMFODLEPOE, Vector3 MNMDECHMAEG, bool EDJMDLCBMBL, [Optional] AudioRolloff DBPEGBOJAMO, [Optional] Action<SFXAudioSource> KAMEFBBABKD, [Optional] FELLLMIMJEO? OMBFAFMLKCL);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource HDOPIFIKGOG(RecRoomAudioClip AGHPBHLHBIG, [Optional] Action<SFXAudioSource> KAMEFBBABKD, [Optional] FELLLMIMJEO? OMBFAFMLKCL);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		[Range(0f, 2f)]
		[Header("Pitch")]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x5F9B440", Offset = "0x5F9A240", VA = "0x185F9B440")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x5F9B490", Offset = "0x5F9A290", VA = "0x185F9B490")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B3F0", Offset = "0x5F9A1F0", VA = "0x185F9B3F0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B400", Offset = "0x5F9A200", VA = "0x185F9B400")]
		public RecRoomAudioClip(AudioClip AGHPBHLHBIG)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu(menuName = "RecRoom/Config/Rec Room Audio Clip Pool Config", fileName = "RecRoomAudioClipPoolConfig")]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B320", Offset = "0x5F9A120", VA = "0x185F9B320")]
		public bool EJHEBGJDFFO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x8853D0", Offset = "0x8841D0", VA = "0x1808853D0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, KCDKGGDJBJM.GNPKNNKDCHF
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct ILCGIEGCOOF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? ACHDDFODBGM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? HBENFHKGCAC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Vector3 JGMJCPNFMGJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Transform GGAHNOFHFOL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AudioRolloff AAMHPHFEALM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float MGBJAELJOLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float HFMDCBDOPBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public NFPCPANDOBP? MECHCFAECIA;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float OGKCDELEIDE
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x5F9ABB0", Offset = "0x5F999B0", VA = "0x185F9ABB0")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public NFPCPANDOBP MFKNPJHMMNM
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x5F9AB60", Offset = "0x5F99960", VA = "0x185F9AB60")]
				get
				{
					return default(NFPCPANDOBP);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct MKILNJPCCHE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public ILCGIEGCOOF playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x5F9AC30", Offset = "0x5F99A30", VA = "0x185F9AC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x5F9B1F0", Offset = "0x5F99FF0", VA = "0x185F9B1F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PLDOAMALJIN : IEnumerator<CPLKNCELBEK>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private CPLKNCELBEK <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private CPLKNCELBEK System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003B")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003D")]
				[Cpp2IlInjected.Address(RVA = "0x7B8F10", Offset = "0x7B7D10", VA = "0x1807B8F10", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7C10A0", Offset = "0x7BFEA0", VA = "0x1807C10A0")]
			[DebuggerHidden]
			public PLDOAMALJIN(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x7BADD0", Offset = "0x7B9BD0", VA = "0x1807BADD0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x5F9B250", Offset = "0x5F9A050", VA = "0x185F9B250", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0x5F9B2D0", Offset = "0x5F9A0D0", VA = "0x185F9B2D0", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private Action<SFXAudioSource> FJIPCEKOIDP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private PICEPJILIEK FLFJDJENLCN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[LNDIHOOGFKF(HLOGMCICCDP.Self, false, false, false)]
		[SerializeField]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private NCBPOKBECKK IMPEHCJECFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private KLFANNGJHOI BPHOBFGMPND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float HFCNOLLOHBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float CPCFJDHMCCA;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string GFNAEJOLEII = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform GGAHNOFHFOL
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7BE940", Offset = "0x7BD740", VA = "0x1807BE940")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x7C24E0", Offset = "0x7C12E0", VA = "0x1807C24E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int CPILJGECBDI
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x5F9CAC0", Offset = "0x5F9B8C0", VA = "0x185F9CAC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool LMHMMEPMGAJ
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x5F9CBA0", Offset = "0x5F9B9A0", VA = "0x185F9CBA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool PJLONLCPFAC
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x5F9CB80", Offset = "0x5F9B980", VA = "0x185F9CB80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float ACHDDFODBGM
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x5F9CBC0", Offset = "0x5F9B9C0", VA = "0x185F9CBC0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float KLMMKCBGOBH
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x5F9CAE0", Offset = "0x5F9B8E0", VA = "0x185F9CAE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B520", Offset = "0x5F9A320", VA = "0x185F9B520")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BD40", Offset = "0x5F9AB40", VA = "0x185F9BD40")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x5F9CA00", Offset = "0x5F9B800", VA = "0x185F9CA00")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C9E0", Offset = "0x5F9B7E0", VA = "0x185F9C9E0")]
		public void UpdateVolume(float APKNJANBIGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C7D0", Offset = "0x5F9B5D0", VA = "0x185F9C7D0")]
		public void UpdatePitch(float FHEOBBOIPBL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C730", Offset = "0x5F9B530", VA = "0x185F9C730")]
		public void UpdateDopplerLevel(float KGFCIPMKPOG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C940", Offset = "0x5F9B740", VA = "0x185F9C940")]
		public void UpdateSpatialBlend(float EPOMHIBINAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C660", Offset = "0x5F9B460", VA = "0x185F9C660")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C020", Offset = "0x5F9AE20", VA = "0x185F9C020")]
		public void Play(AudioClip AGHPBHLHBIG, float APKNJANBIGH, Vector3 MNMDECHMAEG, float EBIEBONEKDL, float KGKHEGAGOIJ, AudioRolloff IIKNDNDMMNG, [Optional] Action<SFXAudioSource> BFJLALGHCCN, [Optional] FELLLMIMJEO? OMBFAFMLKCL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BED0", Offset = "0x5F9ACD0", VA = "0x185F9BED0")]
		[AsyncStateMachine(typeof(MKILNJPCCHE))]
		public Task PlayAsync(AudioClip AGHPBHLHBIG, ILCGIEGCOOF CMCMDGJPINP, CancellationToken MBHHHCCHBAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x5F9B5F0", Offset = "0x5F9A3F0", VA = "0x185F9B5F0")]
		private void EHJDDNHLPGD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x5F9BCF0", Offset = "0x5F9AAF0", VA = "0x185F9BCF0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C690", Offset = "0x5F9B490", VA = "0x185F9C690")]
		public void Scrub(float EHBJJHHNHHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C6F0", Offset = "0x5F9B4F0", VA = "0x185F9C6F0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C590", Offset = "0x5F9B390", VA = "0x185F9C590")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x5F9C510", Offset = "0x5F9B310", VA = "0x185F9C510")]
		[IteratorStateMachine(typeof(PLDOAMALJIN))]
		public IEnumerator<CPLKNCELBEK> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x11356F0", Offset = "0x11344F0", VA = "0x1811356F0", Slot = "4")]
		private void HEEPNFFGDND(bool OOONCECEHDH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x7BADC0", Offset = "0x7B9BC0", VA = "0x1807BADC0")]
		public SFXAudioSource()
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
