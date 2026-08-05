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
public enum BNEFKGPBDIL
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum GIHAHPIILNK
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
public enum MMAPPDLBOJH
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
public enum OIJEHAGDOFJ
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class MHCJEALOEDK
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x64611D0", Offset = "0x64603D0", VA = "0x1864611D0")]
	public static void LNMKNLDABBM(this AudioSource EIOKPFDNDIH, AudioRolloff EDPFNBNNALC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6461100", Offset = "0x6460300", VA = "0x186461100")]
	public static void DIINILGDLML(this AudioSource ECDBCBINIBM, RecRoomAudioClip NLGMMPJJPAL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MEBDCDPBELN
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const float BOFFAPLFINB = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const float NBMMAKDGOLH = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6460FD0", Offset = "0x64601D0", VA = "0x186460FD0")]
	public static float CPEAHGDHGKA(float NOGPLDCGAJA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x6460FA0", Offset = "0x64601A0", VA = "0x186460FA0")]
	public static float BBNPCKHHJDJ(float DNMBIADJDNP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public MEBDCDPBELN()
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public class AudioRolloff
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public AudioRolloffMode rolloffMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float minDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float maxDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		[Tooltip("Only used if the rolloffMode is custom, this is the red volumetric curve.")]
		public AnimationCurve customCurve;

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6460850", Offset = "0x645FA50", VA = "0x186460850")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface ENPJOLHINEC
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, LLCHHDIIONL> ODPPOOMFEND();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AudioMixerGroup MBKKFEBFGGD(MMAPPDLBOJH FBPOGPFFENC);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void LNMKNLDABBM(AudioSource ECDBCBINIBM);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	SFXAudioSource KKCCEJPKOGP(RecRoomAudioClip JKHIECLOPDN, Transform HHBAFLCLKAI, [Optional] AudioRolloff MGBHMHCLEDF, [Optional] Action<SFXAudioSource> HIJGABJIICE);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void HKLPILHNCPP(SFXAudioSource ECDBCBINIBM);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource OCBIIFIIBAN(RecRoomAudioClip[] NKMOHBHFGDI, bool IKMHMGMANHE = false, float DAMDKMHOOKE = 1f, [Optional] Action<SFXAudioSource> HIJGABJIICE);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource LBGCNBGKGHK(RecRoomAudioClip[] NKMOHBHFGDI, Transform HHBAFLCLKAI, [Optional] AudioRolloff MGBHMHCLEDF, bool IKMHMGMANHE = false, [Optional] Action<SFXAudioSource> HIJGABJIICE);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource FJJEDEBOCAF(RecRoomAudioClip HPMPIHEHHGK, Vector3 CKJEELMDBEC, bool MPGADMIOMFK, [Optional] AudioRolloff MGBHMHCLEDF, [Optional] Action<SFXAudioSource> HIJGABJIICE);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource KMJBGMMGCJH(RecRoomAudioClip LMIHCIFFHKP, [Optional] Action<SFXAudioSource> HIJGABJIICE);
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class RecRoomAudioClip
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public AudioClip audioClip;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		[SerializeField]
		[Header("Volume")]
		private bool configureVolumeInDecibel;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		[SerializeField]
		private float volume;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		[Header("Pitch")]
		[Range(0f, 0f)]
		public float pitchVariation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		[Range(-1f, 1f)]
		public float pitchShift;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		[Header("Other")]
		public TextAsset subtitles;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public float LinearVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0x6461A10", Offset = "0x6460C10", VA = "0x186461A10")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x6461AA0", Offset = "0x6460CA0", VA = "0x186461AA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x64619B0", Offset = "0x6460BB0", VA = "0x1864619B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x6461A50", Offset = "0x6460C50", VA = "0x186461A50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x6461960", Offset = "0x6460B60", VA = "0x186461960")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6461970", Offset = "0x6460B70", VA = "0x186461970")]
		public RecRoomAudioClip(AudioClip LMIHCIFFHKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x64617F0", Offset = "0x64609F0", VA = "0x1864617F0")]
		public bool MONGDJMFKMD(RecRoomAudioClip IHIJPIJNLJM)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CreateAssetMenu]
	public class RecRoomAudioClipPoolConfig : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		[SerializeField]
		private RecRoomAudioClip[] audioClips;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public RecRoomAudioClip[] AudioClips
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6461720", Offset = "0x6460920", VA = "0x186461720")]
		public bool IHBNEEABLKB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xE21BA0", Offset = "0xE20DA0", VA = "0x180E21BA0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXAudioSource : MonoBehaviour, AEFHIEMBGMB.KMMKPHPPAJJ
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct MGHAJIMCCJD
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private const float BHJBPPBFBFI = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private const float OADDPPNAFDO = 1f;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private const MMAPPDLBOJH GDFKMFPEINH = MMAPPDLBOJH.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public float? EKBFOEGKLMC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public float? JLOCLNNPGKL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Vector3 LNGFLCPEPDP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Transform PEELLPLMDBO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public AudioRolloff ACCHOPDDGIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float KBMJODGIJPO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float PMFBNPEBEJH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public MMAPPDLBOJH? JIHLHKEKNCN;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public float OHPMPJFJKEL
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x6461070", Offset = "0x6460270", VA = "0x186461070")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public MMAPPDLBOJH JCIENBFKEEM
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x6461020", Offset = "0x6460220", VA = "0x186461020")]
				get
				{
					return default(MMAPPDLBOJH);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct OOBHEFLDAFN : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public MGHAJIMCCJD playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6461290", Offset = "0x6460490", VA = "0x186461290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6CF320", Offset = "0x6CE520", VA = "0x1806CF320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class EDIBCLHNIBM : IEnumerator<MOELIBACAGH>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private MOELIBACAGH <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private MOELIBACAGH System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6C70C0", Offset = "0x6C62C0", VA = "0x1806C70C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6CB200", Offset = "0x6CA400", VA = "0x1806CB200")]
			[DebuggerHidden]
			public EDIBCLHNIBM(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6E0EB0", Offset = "0x6E00B0", VA = "0x1806E0EB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x6460870", Offset = "0x645FA70", VA = "0x186460870", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x6460930", Offset = "0x645FB30", VA = "0x186460930", Slot = "8")]
			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public bool Is3DSFX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private Action<SFXAudioSource> GNEGOGGBDKG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private MONKECHCONN FENFMMLMOHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[PLDPAHFKOHO(BCMNNOMINIG.Self, false, false, false)]
		private AudioSource _audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private PEDGOFLLMDJ MNBKDCPGIIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private ENPJOLHINEC JNJDJCIOJMH;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private const string GGDFFHLHEJN = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform PEELLPLMDBO
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6DD6F0", Offset = "0x6DC8F0", VA = "0x1806DD6F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x75FAE0", Offset = "0x75ECE0", VA = "0x18075FAE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioSource CNOAEDAFAEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6CE570", Offset = "0x6CD770", VA = "0x1806CE570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x6461B20", Offset = "0x6460D20", VA = "0x186461B20")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x64622B0", Offset = "0x64614B0", VA = "0x1864622B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6462A50", Offset = "0x6461C50", VA = "0x186462A50")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6462540", Offset = "0x6461740", VA = "0x186462540")]
		public void Play(AudioClip LMIHCIFFHKP, float HMJLIHEEPOH, Vector3 CKJEELMDBEC, float OBNBKDOFGAD, float AHGDDFCAPOD, AudioRolloff EDPFNBNNALC, [Optional] Action<SFXAudioSource> NJLHECDDFEK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x64623D0", Offset = "0x64615D0", VA = "0x1864623D0")]
		[AsyncStateMachine(typeof(OOBHEFLDAFN))]
		public Task PlayAsync(AudioClip LMIHCIFFHKP, MGHAJIMCCJD GNGLALDLIOC, CancellationToken OLHHOODBFDC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6461C70", Offset = "0x6460E70", VA = "0x186461C70")]
		private void OEPNDOOFNJG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6461C10", Offset = "0x6460E10", VA = "0x186461C10")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x64629B0", Offset = "0x6461BB0", VA = "0x1864629B0")]
		public void Scrub(float KMIINHDMOMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6462A10", Offset = "0x6461C10", VA = "0x186462A10")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6461BC0", Offset = "0x6460DC0", VA = "0x186461BC0")]
		public void CancelAudioSourceRelease()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x64628C0", Offset = "0x6461AC0", VA = "0x1864628C0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6462850", Offset = "0x6461A50", VA = "0x186462850")]
		[IteratorStateMachine(typeof(EDIBCLHNIBM))]
		public IEnumerator<MOELIBACAGH> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6461C60", Offset = "0x6460E60", VA = "0x186461C60", Slot = "4")]
		private void NJEDEBBOBKO(bool BEIBHGPBPHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE24550", Offset = "0xE23750", VA = "0x180E24550")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class EGIIOKJKKGL
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] LAFDEEMEPDM;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int AHBPGGLKEKP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int MAHPDNGMMFO;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger NMOJFJKJLEG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
	public EGIIOKJKKGL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6460970", Offset = "0x645FB70", VA = "0x186460970")]
	private static string CIEKLEOAFAL(byte[] GPHMIGDKMEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x6460A80", Offset = "0x645FC80", VA = "0x186460A80")]
	public static string NOFFLEGCGLA(byte[] NPNCGJAPKIL, bool FBFFLNHILGA)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x6C8B30", Offset = "0x6C7D30", VA = "0x1806C8B30")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000013")]
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
