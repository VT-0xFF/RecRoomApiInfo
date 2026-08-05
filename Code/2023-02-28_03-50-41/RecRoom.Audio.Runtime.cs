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
public enum LKBAHPOHJIE
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum PAFGEKLEDHF
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
public enum AOBJGLDFAJK
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
public enum LGGPENEENLL
{
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class DEGNOEFOJDG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x646C6E0", Offset = "0x646B0E0", VA = "0x18646C6E0")]
	public static void HNLCLFOEAMC(this AudioSource BGGEABMJKHJ, AudioRolloff AADGCNIFMJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x646C610", Offset = "0x646B010", VA = "0x18646C610")]
	public static void BBAOHOFJGCM(this AudioSource DPFMDGNHLKB, RecRoomAudioClip PFKJOEMNDPG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class HPGPEOOBFEE
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public const float PGHDGAICPDO = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public const float KNNEIDGAMMN = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x646CC30", Offset = "0x646B630", VA = "0x18646CC30")]
	public static float GKPBOBBJDMI(float CBLMLHHFKII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x646CC80", Offset = "0x646B680", VA = "0x18646CC80")]
	public static float PKIDLCBGLNF(float HKOKKDDPAPI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public HPGPEOOBFEE()
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
		[Cpp2IlInjected.Address(RVA = "0x646C510", Offset = "0x646AF10", VA = "0x18646C510")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public interface EAIDNPMPEEK
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, EAPIMBHAJCF> FGOKKLKOHJP();

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "1")]
	AudioMixerGroup CDDDGKABMGJ(AOBJGLDFAJK OHKBHLNEDME);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "2")]
	void HNLCLFOEAMC(AudioSource DPFMDGNHLKB);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "3")]
	SFXAudioSource ONKCJHKLNMG(RecRoomAudioClip BMNBCDGPNLO, Transform BNLOFIGMILH, [Optional] AudioRolloff KDCOOBABOIP, [Optional] Action<SFXAudioSource> JJLJPFHIHJL);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void AFCPCDNEKIB(SFXAudioSource DPFMDGNHLKB);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource MEDKNGPCEGA(RecRoomAudioClip[] NOJDAODFLGP, bool JGPHPDNJNBO = false, float NLACDFEFMMF = 1f, [Optional] Action<SFXAudioSource> JJLJPFHIHJL);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource KCGFMBOCBED(RecRoomAudioClip[] NOJDAODFLGP, Transform BNLOFIGMILH, [Optional] AudioRolloff KDCOOBABOIP, bool JGPHPDNJNBO = false, [Optional] Action<SFXAudioSource> JJLJPFHIHJL);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource FBDFKAJOGPM(RecRoomAudioClip EGBHHFCCLKE, Vector3 OMMEPJAJELH, bool ADKPHHDHHPL, [Optional] AudioRolloff KDCOOBABOIP, [Optional] Action<SFXAudioSource> JJLJPFHIHJL);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource FPGCLAFFEDA(RecRoomAudioClip CGLLKADIKDD, [Optional] Action<SFXAudioSource> JJLJPFHIHJL);
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
			[Cpp2IlInjected.Address(RVA = "0x646D6D0", Offset = "0x646C0D0", VA = "0x18646D6D0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x646D760", Offset = "0x646C160", VA = "0x18646D760")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x646D670", Offset = "0x646C070", VA = "0x18646D670")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x646D710", Offset = "0x646C110", VA = "0x18646D710")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x646D620", Offset = "0x646C020", VA = "0x18646D620")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x646D630", Offset = "0x646C030", VA = "0x18646D630")]
		public RecRoomAudioClip(AudioClip CGLLKADIKDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x646D4B0", Offset = "0x646BEB0", VA = "0x18646D4B0")]
		public bool CPMCFNPMCON(RecRoomAudioClip DFHJPOKNFFB)
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
			[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x646D3E0", Offset = "0x646BDE0", VA = "0x18646D3E0")]
		public bool DEGLEGIMGMO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xE1BFB0", Offset = "0xE1A9B0", VA = "0x180E1BFB0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class SFXAudioSource : MonoBehaviour, CMEMELMPMPI.OKHOMCILKDB
	{
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public struct BDKFGKNOLGO
		{
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private const float IPNHFFIABBD = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private const float HDDACDLHPMH = 1f;

			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private const AOBJGLDFAJK JNJOCDJPOMA = AOBJGLDFAJK.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public float? OPEHBLDMGLF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public float? GDMFNLJCHEC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public Vector3 KDCLNGLFCJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public Transform BKOGAHJPKLE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public AudioRolloff CDLAACHFAGC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public float DNNFHPGLEOA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public float GNJEEEPKJMO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AOBJGLDFAJK? ONNMMOMOIAO;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public float APJKMNLFLMG
			{
				[Cpp2IlInjected.Token(Token = "0x600002B")]
				[Cpp2IlInjected.Address(RVA = "0x646C580", Offset = "0x646AF80", VA = "0x18646C580")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public AOBJGLDFAJK PCHFIHEJOEB
			{
				[Cpp2IlInjected.Token(Token = "0x600002C")]
				[Cpp2IlInjected.Address(RVA = "0x646C530", Offset = "0x646AF30", VA = "0x18646C530")]
				get
				{
					return default(AOBJGLDFAJK);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct GIHKIEJLECB : IAsyncStateMachine
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
			public BDKFGKNOLGO playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x646C7A0", Offset = "0x646B1A0", VA = "0x18646C7A0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6C9320", Offset = "0x6C7D20", VA = "0x1806C9320", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class NCJMLLHNHHG : IEnumerator<MJOGGKCIPED>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			private MJOGGKCIPED <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			private MJOGGKCIPED System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6C10C0", Offset = "0x6BFAC0", VA = "0x1806C10C0", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6C5200", Offset = "0x6C3C00", VA = "0x1806C5200")]
			[DebuggerHidden]
			public NCJMLLHNHHG(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x6DAEB0", Offset = "0x6D98B0", VA = "0x1806DAEB0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x646D2E0", Offset = "0x646BCE0", VA = "0x18646D2E0", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x646D3A0", Offset = "0x646BDA0", VA = "0x18646D3A0", Slot = "8")]
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
		private Action<SFXAudioSource> ENDJCCCGFNP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private NPKEGPKMBCL NGJMDHEDBCC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[SerializeField]
		[KJPINCGBMNI(BPOBPCLEAHD.Self, false, false, false)]
		private AudioSource _audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private ALJDLEMICMK GNFDFHMJMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private EAIDNPMPEEK DBHNBMEHGAH;

		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private const string GKOFEDMBNFF = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform BKOGAHJPKLE
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x6D76F0", Offset = "0x6D60F0", VA = "0x1806D76F0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x759AE0", Offset = "0x7584E0", VA = "0x180759AE0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public AudioSource OHBFFKBFHAK
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6C8570", Offset = "0x6C6F70", VA = "0x1806C8570")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x646D7E0", Offset = "0x646C1E0", VA = "0x18646D7E0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x646DF70", Offset = "0x646C970", VA = "0x18646DF70")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x646E710", Offset = "0x646D110", VA = "0x18646E710")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x646E200", Offset = "0x646CC00", VA = "0x18646E200")]
		public void Play(AudioClip CGLLKADIKDD, float JLDAKDFCCDN, Vector3 OMMEPJAJELH, float GPMLOHDBGAG, float HCJIACGDELF, AudioRolloff AADGCNIFMJJ, [Optional] Action<SFXAudioSource> MGAGJGHBPDN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x646E090", Offset = "0x646CA90", VA = "0x18646E090")]
		[AsyncStateMachine(typeof(GIHKIEJLECB))]
		public Task PlayAsync(AudioClip CGLLKADIKDD, BDKFGKNOLGO LACCCNPHKIL, CancellationToken KAKEKEHNCME)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x646D930", Offset = "0x646C330", VA = "0x18646D930")]
		private void MIBKJPBBBEG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x646D8E0", Offset = "0x646C2E0", VA = "0x18646D8E0")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x646E670", Offset = "0x646D070", VA = "0x18646E670")]
		public void Scrub(float AHOJLECBNNM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x646E6D0", Offset = "0x646D0D0", VA = "0x18646E6D0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x646D880", Offset = "0x646C280", VA = "0x18646D880")]
		public void CancelAudioSourceRelease()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x646E580", Offset = "0x646CF80", VA = "0x18646E580")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x646E510", Offset = "0x646CF10", VA = "0x18646E510")]
		[IteratorStateMachine(typeof(NCJMLLHNHHG))]
		public IEnumerator<MJOGGKCIPED> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x646D8D0", Offset = "0x646C2D0", VA = "0x18646D8D0", Slot = "4")]
		private void IFPANNKPLBB(bool MHJJEDNLELL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0xE1E960", Offset = "0xE1D360", VA = "0x180E1E960")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class KEBPIDDMFLP
{
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private static byte[] PACJNBAODEE;

	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private static int CIPMBADAHHP;

	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static int EAOHPIEEBJK;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static BigInteger CAFOPFCNDHG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
	public KEBPIDDMFLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x646D000", Offset = "0x646BA00", VA = "0x18646D000")]
	private static string PBGMOKJNJDM(byte[] DLAMIJMLOOE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x646CCB0", Offset = "0x646B6B0", VA = "0x18646CCB0")]
	public static string NPAMJBENNGG(byte[] FMIGDHLBIKP, bool BLHGHBBBDBI)
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
		[Cpp2IlInjected.Address(RVA = "0x6C2B30", Offset = "0x6C1530", VA = "0x1806C2B30")]
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
