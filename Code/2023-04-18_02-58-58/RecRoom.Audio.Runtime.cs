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
public enum LPDDNINEKAP
{
	[Cpp2IlInjected.Token(Token = "0x4000002")]
	_2D,
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	_3D
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public enum NOMDJBMGHMJ
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
public enum HHOIEGJNNEC
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
public struct PDAIIFPEFAG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	public readonly HHOIEGJNNEC NJHJHNEHPAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	public readonly string AJNLFJNDGGB;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x67B8690", Offset = "0x67B7890", VA = "0x1867B8690")]
	public PDAIIFPEFAG(HHOIEGJNNEC LAEAGAJDAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x67B8620", Offset = "0x67B7820", VA = "0x1867B8620")]
	public PDAIIFPEFAG(HHOIEGJNNEC LAEAGAJDAFO, string ILMHPJCNPFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x67B8590", Offset = "0x67B7790", VA = "0x1867B8590")]
	public bool DPEEPDHHAAA(HHOIEGJNNEC BFFEBHCIPGM, string ALEEOANNMPK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public enum OGJHFKGLLGE
{
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	Logarithmic,
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	Linear
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BGPKHKHMNBO
{
	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x67B7860", Offset = "0x67B6A60", VA = "0x1867B7860")]
	public static void GOJDGDNMKFN(this AudioSource LAJEMHNCJJJ, AudioRolloff EOFMABJLPAB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x67B7920", Offset = "0x67B6B20", VA = "0x1867B7920")]
	public static void KNHAGNEFIBG(this AudioSource PLIJJENJJOP, RecRoomAudioClip JCNDDPGMCDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public class AAGKHFIMOKN
{
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public const float LLGNJCAMIKB = -80f;

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public const float CPBAOKEHDOH = 0f;

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x67B77F0", Offset = "0x67B69F0", VA = "0x1867B77F0")]
	public static float PLAMBDKLIPC(float NEOBNNPEMII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x67B77C0", Offset = "0x67B69C0", VA = "0x1867B77C0")]
	public static float MLIBFMHKGCE(float FPCLPPMDAFA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public AAGKHFIMOKN()
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
		[Cpp2IlInjected.Address(RVA = "0x67B7840", Offset = "0x67B6A40", VA = "0x1867B7840")]
		public AudioRolloff()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public interface MGDHHGCAICD
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	int JPNNFKJGJPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(Slot = "0")]
	Dictionary<string, MIBJNNKFLND> LDEIDIELKMB();

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IList<(string, PDAIIFPEFAG)> NHFODLIMNFM();

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(Slot = "2")]
	AudioMixerGroup COPMNHEHBAJ(HHOIEGJNNEC LAEAGAJDAFO);

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(Slot = "3")]
	AudioMixerGroup FFCIFLINDDD(PDAIIFPEFAG IMHIOOKAHPC);

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	void GOJDGDNMKFN(AudioSource PLIJJENJJOP);

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	SFXAudioSource LHEINOLCFFM(RecRoomAudioClip HFMBEKEICOC, Transform EHFFICIAODF, [Optional] AudioRolloff OGHABJFFBOB, [Optional] Action<SFXAudioSource> JLEAAAFEOJN, [Optional] PDAIIFPEFAG? LAEAGAJDAFO);

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(Slot = "6")]
	void BCGHJPDMCGK(SFXAudioSource PLIJJENJJOP);

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "7")]
	SFXAudioSource KHDPPNLIPEJ(RecRoomAudioClip[] CADPONIDLFD, bool EIEJDGDJAAM = false, float MJHCPDDFHJH = 1f, [Optional] Action<SFXAudioSource> JLEAAAFEOJN, [Optional] PDAIIFPEFAG? LAEAGAJDAFO);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "8")]
	SFXAudioSource EGJMPJOCEIP(RecRoomAudioClip[] CADPONIDLFD, Transform EHFFICIAODF, [Optional] AudioRolloff OGHABJFFBOB, bool EIEJDGDJAAM = false, [Optional] Action<SFXAudioSource> JLEAAAFEOJN, [Optional] PDAIIFPEFAG? LAEAGAJDAFO);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "9")]
	SFXAudioSource IAPLGECBADI(RecRoomAudioClip OAAADBMOMNE, Vector3 PDFEDMAOMNH, bool MKBGHFKCHHO, [Optional] AudioRolloff OGHABJFFBOB, [Optional] Action<SFXAudioSource> JLEAAAFEOJN, [Optional] PDAIIFPEFAG? LAEAGAJDAFO);

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(Slot = "10")]
	SFXAudioSource HOLDAODDLCN(RecRoomAudioClip DLLECDOAMDE, [Optional] Action<SFXAudioSource> JLEAAAFEOJN, [Optional] PDAIIFPEFAG? LAEAGAJDAFO);
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
			[Cpp2IlInjected.Address(RVA = "0x67B8B20", Offset = "0x67B7D20", VA = "0x1867B8B20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x67B8BB0", Offset = "0x67B7DB0", VA = "0x1867B8BB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DecibelVolume
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x67B8AC0", Offset = "0x67B7CC0", VA = "0x1867B8AC0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x67B8B60", Offset = "0x67B7D60", VA = "0x1867B8B60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x67B8A70", Offset = "0x67B7C70", VA = "0x1867B8A70")]
		public RecRoomAudioClip()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x67B8A80", Offset = "0x67B7C80", VA = "0x1867B8A80")]
		public RecRoomAudioClip(AudioClip DLLECDOAMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x67B8900", Offset = "0x67B7B00", VA = "0x1867B8900")]
		public bool INPBKODPGAA(RecRoomAudioClip HNPEBINPOBO)
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
			[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x67B8830", Offset = "0x67B7A30", VA = "0x1867B8830")]
		public bool MBOPNNFKNNE()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x6F9FF0", Offset = "0x6F91F0", VA = "0x1806F9FF0")]
		public RecRoomAudioClipPoolConfig()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class SFXAudioSource : MonoBehaviour, NIIKGHOMJLA.DLAAAIOLKJP
	{
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public struct JAIOLKMHIGA
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private const float DAPGEMNAAPI = 0.5f;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private const float DDAMAMBODFN = 1f;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private const HHOIEGJNNEC PJLEAMPKDPD = HHOIEGJNNEC.Sfx;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public float? NBJHGMFFFLH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public float? PCONCCNBGEN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			public Vector3 PEOIPOGPOCM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			public Transform HHPMCJJJBKN;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			public AudioRolloff ANECMEANHMH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public float FBCHCBAOIFK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public float JCPADEKKHFL;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public HHOIEGJNNEC? NJHJHNEHPAF;

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public float JCCKCOKEPAO
			{
				[Cpp2IlInjected.Token(Token = "0x6000031")]
				[Cpp2IlInjected.Address(RVA = "0x67B7E80", Offset = "0x67B7080", VA = "0x1867B7E80")]
				get
				{
					return default(float);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000008")]
			public HHOIEGJNNEC NELEAJNCGJC
			{
				[Cpp2IlInjected.Token(Token = "0x6000032")]
				[Cpp2IlInjected.Address(RVA = "0x67B7F10", Offset = "0x67B7110", VA = "0x1867B7F10")]
				get
				{
					return default(HHOIEGJNNEC);
				}
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct DBDMLDIOBGD : IAsyncStateMachine
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
			public JAIOLKMHIGA playParams;

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
			[Cpp2IlInjected.Address(RVA = "0x67B79F0", Offset = "0x67B6BF0", VA = "0x1867B79F0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x87A5F0", Offset = "0x8797F0", VA = "0x18087A5F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		[CompilerGenerated]
		private sealed class PPCOIAFFEIF : IEnumerator<EGGPGCCKPCO>, IEnumerator, IDisposable
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			private int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private EGGPGCCKPCO <>2__current;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			public SFXAudioSource <>4__this;

			[Cpp2IlInjected.Token(Token = "0x17000009")]
			private EGGPGCCKPCO System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000038")]
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "4")]
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
				[Cpp2IlInjected.Address(RVA = "0x6FA000", Offset = "0x6F9200", VA = "0x1806FA000", Slot = "7")]
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x871950", Offset = "0x870B50", VA = "0x180871950")]
			[DebuggerHidden]
			public PPCOIAFFEIF(int <>1__state)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x6F84D0", Offset = "0x6F76D0", VA = "0x1806F84D0", Slot = "5")]
			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x67B8730", Offset = "0x67B7930", VA = "0x1867B8730", Slot = "6")]
			private bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x67B87F0", Offset = "0x67B79F0", VA = "0x1867B87F0", Slot = "8")]
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
		private Action<SFXAudioSource> CNMPHCCPGMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		private JKHCJAJHGAO LOFHOJBIICL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[SerializeField]
		[ELEHEHIOAGB(MFGBMPAPHGB.Self, false, false, false)]
		private AudioSource _audioSource;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private IILDCCEMGBA PFGCMJCEEMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private MGDHHGCAICD LBAJJDADBHG;

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const string KIDDGCDENKE = "SafePlaySFXAudioSourceSounds";

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public Transform HHPMCJJJBKN
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x75C700", Offset = "0x75B900", VA = "0x18075C700")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x7B43F0", Offset = "0x7B35F0", VA = "0x1807B43F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public AudioSource AFHJCHKECFL
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6FB850", Offset = "0x6FAA50", VA = "0x1806FB850")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x67B8C30", Offset = "0x67B7E30", VA = "0x1867B8C30")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x67B93B0", Offset = "0x67B85B0", VA = "0x1867B93B0")]
		private void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x67B9C10", Offset = "0x67B8E10", VA = "0x1867B9C10")]
		private void Update()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x67B9650", Offset = "0x67B8850", VA = "0x1867B9650")]
		public void Play(AudioClip DLLECDOAMDE, float COFONCKAJCK, Vector3 PDFEDMAOMNH, float EOBDFMAAGOG, float HGLGKIJHMBG, AudioRolloff EOFMABJLPAB, [Optional] Action<SFXAudioSource> IKBBJIJDLGN, [Optional] PDAIIFPEFAG? LAEAGAJDAFO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x67B94E0", Offset = "0x67B86E0", VA = "0x1867B94E0")]
		[AsyncStateMachine(typeof(DBDMLDIOBGD))]
		public Task PlayAsync(AudioClip DLLECDOAMDE, JAIOLKMHIGA GBGDOBKHAFC, CancellationToken NDKAKDJMDIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x67B8D20", Offset = "0x67B7F20", VA = "0x1867B8D20")]
		private void LGMANENONBL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x67B9360", Offset = "0x67B8560", VA = "0x1867B9360")]
		public void Loop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x67B9B70", Offset = "0x67B8D70", VA = "0x1867B9B70")]
		public void Scrub(float BBGNJMKOHPL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x67B9BD0", Offset = "0x67B8DD0", VA = "0x1867B9BD0")]
		public void Stop()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x67B8CD0", Offset = "0x67B7ED0", VA = "0x1867B8CD0")]
		public void CancelAudioSourceRelease()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x67B9A80", Offset = "0x67B8C80", VA = "0x1867B9A80")]
		public void Release()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x67B9A10", Offset = "0x67B8C10", VA = "0x1867B9A10")]
		[IteratorStateMachine(typeof(PPCOIAFFEIF))]
		public IEnumerator<EGGPGCCKPCO> ReleaseAfterPlaying()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67B94D0", Offset = "0x67B86D0", VA = "0x1867B94D0", Slot = "4")]
		private void PFBAKFLMPIH(bool FBHDABEFLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6FB670", Offset = "0x6FA870", VA = "0x1806FB670")]
		public SFXAudioSource()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class NFLCIDIFMGO
{
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private static byte[] OFIIJNPNABI;

	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private static int AJJJCGJNNOF;

	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private static int HJKCCLPHOML;

	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private static BigInteger KJPEHCDEKDE;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
	public NFLCIDIFMGO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x67B7F60", Offset = "0x67B7160", VA = "0x1867B7F60")]
	private static string DHECIEFNHGE(byte[] EFNJCAIBDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x67B8070", Offset = "0x67B7270", VA = "0x1867B8070")]
	public static string EAFEFBMLFGD(byte[] ODBGNNDKAMK, bool MKOEKIGFDJD)
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
		[Cpp2IlInjected.Address(RVA = "0x703570", Offset = "0x702770", VA = "0x180703570")]
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
