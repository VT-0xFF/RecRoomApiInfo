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
public enum FALMJNAJKOG
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum INLDJEFBKAE
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
public enum KAILBGEMMFI
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
public struct EIOHHNMMJBK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly KAILBGEMMFI MIOINNNKFHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly string PNIKNNOCAAL;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C220", Offset = "0x6F1B620", VA = "0x186F1C220")]
	public EIOHHNMMJBK(KAILBGEMMFI NCNBHDGFPLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C1B0", Offset = "0x6F1B5B0", VA = "0x186F1C1B0")]
	public EIOHHNMMJBK(KAILBGEMMFI NCNBHDGFPLG, string NKFLJEKCPEO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C120", Offset = "0x6F1B520", VA = "0x186F1C120")]
	public bool PICMANFOBDM(KAILBGEMMFI AOBKANCIBAP, string CGNGMCOHIHG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum CEAALBNIIKC
{
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public interface JEAHJEGDPHP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int LDKPJOJHPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, EHMPLBFMIMH> OGMICGEHFGP();

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, EIOHHNMMJBK)> HEDKPKIBAKG();

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup LDECLJDODMC(KAILBGEMMFI NCNBHDGFPLG);

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup EDFENHNOJOG(EIOHHNMMJBK DAMLANKAAJB);

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(Slot = "4")]
	SFXAudioSource KOPOFPKMEIK(RecRoomAudioClip FPCGEOJPMHH, Transform MLFOGHMGPDG, [Optional] AudioRolloff HFKLALBEHEE, [Optional] Action<SFXAudioSource> AFHLNBJHLGB, [Optional] EIOHHNMMJBK? NCNBHDGFPLG);

	[Cpp2IlInjected.Token(Token = "0x6000009")]
	[Cpp2IlInjected.Address(Slot = "5")]
	void GDIILGIOFOE(SFXAudioSource GGKHAIDKEHK);

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "6")]
	SFXAudioSource FOBDLIGCOME(RecRoomAudioClip[] KAAOGCPHJKJ, bool MLKKPNIPLGH = false, float PECENODNFHC = 1f, [Optional] Action<SFXAudioSource> AFHLNBJHLGB, [Optional] EIOHHNMMJBK? NCNBHDGFPLG);

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource LOLMPIPHOIO(RecRoomAudioClip[] KAAOGCPHJKJ, Transform MLFOGHMGPDG, [Optional] AudioRolloff HFKLALBEHEE, bool MLKKPNIPLGH = false, [Optional] Action<SFXAudioSource> AFHLNBJHLGB, [Optional] EIOHHNMMJBK? NCNBHDGFPLG);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource JOPELCIHCFO(RecRoomAudioClip HDIJHKMDLJI, Vector3 GAKPKGDNIKB, bool BLCLMGLBCJN, [Optional] AudioRolloff HFKLALBEHEE, [Optional] Action<SFXAudioSource> AFHLNBJHLGB, [Optional] EIOHHNMMJBK? NCNBHDGFPLG);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource KKCHALCKNMF(RecRoomAudioClip PCJFEMDCACE, [Optional] Action<SFXAudioSource> AFHLNBJHLGB, [Optional] EIOHHNMMJBK? NCNBHDGFPLG);
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class FNLILDDMIEO
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C2C0", Offset = "0x6F1B6C0", VA = "0x186F1C2C0")]
	public static float DAJEMOLFKLH(float NFJDIDJMEJN)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C310", Offset = "0x6F1B710", VA = "0x186F1C310")]
	public static float FEDHCIBJKBB(float JGAOFHAODOD)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class EBCDHNPCKHC
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6F1C060", Offset = "0x6F1B460", VA = "0x186F1C060")]
	public static void LPGGJOEBKBN(this AudioSource HBGGNMAOOEH, AudioRolloff EECKOHIJKKM)
	{
	}
}
namespace RecRoom.Audio
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
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

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6F1BDA0", Offset = "0x6F1B1A0", VA = "0x186F1BDA0")]
		public float KBNKBGCMDKA(float LLNGFBAMAGK)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6F1C040", Offset = "0x6F1B440", VA = "0x186F1C040")]
		public AudioRolloff()
		{
		}
	}
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
		[Header("Pitch")]
		[Range(0f, 0f)]
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
			[Cpp2IlInjected.Address(RVA = "0x6F1CC50", Offset = "0x6F1C050", VA = "0x186F1CC50")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x6F1CC90", Offset = "0x6F1C090", VA = "0x186F1CC90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CBE0", Offset = "0x6F1BFE0", VA = "0x186F1CBE0")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CC00", Offset = "0x6F1C000", VA = "0x186F1CC00")]
		public RecRoomAudioClip(AudioClip PCJFEMDCACE)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CreateAssetMenu]
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
			[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CB10", Offset = "0x6F1BF10", VA = "0x186F1CB10")]
		public bool JLAMDJJBMHL()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x992770", Offset = "0x991B70", VA = "0x180992770")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, FKAJKPPBAFJ.KGGCNFFJFAK
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct IPKDLCLOKMO
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? DHOONFOPCFO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public float? IJDBDJMPIOP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Vector3 KGEFOILJABA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public Transform JPHGEPMOMGA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public AudioRolloff IMAFBFLGGJP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float KKJMBCEKFGF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public float ELAOGPFIDBP;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public KAILBGEMMFI? MIOINNNKFHJ;

			[Cpp2IlInjected.Token(Token = "0x1700000A")]
			public float PKGKBBEJJPC
			{
				[Cpp2IlInjected.Token(Token = "0x6000034")]
				[Cpp2IlInjected.Address(RVA = "0x6F1C340", Offset = "0x6F1B740", VA = "0x186F1C340")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000B")]
			public KAILBGEMMFI NDIFOPBBKBK
			{
				[Cpp2IlInjected.Token(Token = "0x6000035")]
				[Cpp2IlInjected.Address(RVA = "0x6F1C3D0", Offset = "0x6F1B7D0", VA = "0x186F1C3D0")]
				get
				{
					return default(KAILBGEMMFI);
				}
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private sealed class LKFLHFHINGE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			public AudioClip clip;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			public IPKDLCLOKMO playParams;

			[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private float <pitch>5__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private YieldAwaitable.YieldAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x7EA760", Offset = "0x7E9B60", VA = "0x1807EA760")]
			public LKFLHFHINGE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x6F1C4E0", Offset = "0x6F1B8E0", VA = "0x186F1C4E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class KCKLMCADDLB : IEnumerator<LJHFBCJIPCN>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			private LJHFBCJIPCN <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x1700000C")]
			private LJHFBCJIPCN System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003C")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "4")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700000D")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600003E")]
				[Cpp2IlInjected.Address(RVA = "0x7F3130", Offset = "0x7F2530", VA = "0x1807F3130", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xA21140", Offset = "0xA20540", VA = "0x180A21140")]
			[DebuggerHidden]
			public KCKLMCADDLB(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x7EB120", Offset = "0x7EA520", VA = "0x1807EB120", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0x6F1C420", Offset = "0x6F1B820", VA = "0x186F1C420", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0x6F1C4A0", Offset = "0x6F1B8A0", VA = "0x186F1C4A0", Slot = "8")]
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
		private Action<SFXAudioSource> LEFEAHLEPNM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private HPLBPNIMMDC CGHAGJAMMGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[SerializeField]
		[ODADJIGNFAB(NKLEIIOOMFD.Self, false, false, false)]
		private AudioSource audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private JALNCDMAJCJ EPGJHBENCKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private JEAHJEGDPHP MAKDOOKLHHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private float KGBBACOOMOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private float KPOMFEJECNE;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string LPJMFKNMNAM = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public Transform JPHGEPMOMGA
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8BC350", Offset = "0x8BB750", VA = "0x1808BC350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x940BC0", Offset = "0x93FFC0", VA = "0x180940BC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public int ELCNHBILPJH
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F1E3C0", Offset = "0x6F1D7C0", VA = "0x186F1E3C0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool PLBBMHDJNNI
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6F1E4B0", Offset = "0x6F1D8B0", VA = "0x186F1E4B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KLCGIOIKKFA
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x6F1E490", Offset = "0x6F1D890", VA = "0x186F1E490")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public float DHOONFOPCFO
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x6F1E4D0", Offset = "0x6F1D8D0", VA = "0x186F1E4D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public float HLEDKMHMJLA
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x6F1E3E0", Offset = "0x6F1D7E0", VA = "0x186F1E3E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CD10", Offset = "0x6F1C110", VA = "0x186F1CD10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D5D0", Offset = "0x6F1C9D0", VA = "0x186F1D5D0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E290", Offset = "0x6F1D690", VA = "0x186F1E290")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E270", Offset = "0x6F1D670", VA = "0x186F1E270")]
		public void UpdateVolume(float NPJKPAAFLFJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E050", Offset = "0x6F1D450", VA = "0x186F1E050")]
		public void UpdatePitch(float GEMLBCLAHAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DFB0", Offset = "0x6F1D3B0", VA = "0x186F1DFB0")]
		public void UpdateDopplerLevel(float GKBGJCLECGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E1D0", Offset = "0x6F1D5D0", VA = "0x186F1E1D0")]
		public void UpdateSpatialBlend(float OPEAGCIMFFN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DED0", Offset = "0x6F1D2D0", VA = "0x186F1DED0")]
		public void ResetTime()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D920", Offset = "0x6F1CD20", VA = "0x186F1D920")]
		public void Play(AudioClip PCJFEMDCACE, float NPJKPAAFLFJ, Vector3 GAKPKGDNIKB, float JOPPPAJANFG, float AHMKCLLGPMN, AudioRolloff EECKOHIJKKM, [Optional] Action<SFXAudioSource> NNDDJGCHAKO, [Optional] EIOHHNMMJBK? NCNBHDGFPLG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D760", Offset = "0x6F1CB60", VA = "0x186F1D760")]
		[DebuggerStepThrough]
		[AsyncStateMachine(typeof(LKFLHFHINGE))]
		public Task PlayAsync(AudioClip PCJFEMDCACE, IPKDLCLOKMO BGLJNPCDIPD, CancellationToken DNKHCCGNODC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6F1CDD0", Offset = "0x6F1C1D0", VA = "0x186F1CDD0")]
		private void DNHEBGMOJFK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D580", Offset = "0x6F1C980", VA = "0x186F1D580")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DF00", Offset = "0x6F1D300", VA = "0x186F1DF00")]
		public void Scrub(float FEDAMNGKFGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DF70", Offset = "0x6F1D370", VA = "0x186F1DF70")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DDE0", Offset = "0x6F1D1E0", VA = "0x186F1DDE0")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6F1DD70", Offset = "0x6F1D170", VA = "0x186F1DD70")]
		[IteratorStateMachine(typeof(KCKLMCADDLB))]
		public IEnumerator<LJHFBCJIPCN> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6F1D570", Offset = "0x6F1C970", VA = "0x186F1D570", Slot = "4")]
		private void HNKFMPADJGI(bool IDLFGFDILBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6F1E360", Offset = "0x6F1D760", VA = "0x186F1E360")]
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
